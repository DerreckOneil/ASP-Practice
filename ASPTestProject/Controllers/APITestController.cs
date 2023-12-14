namespace ASPTestProject.Controllers
{
    using System.IO;
    using System.Net;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using File = System.IO.File;
    using MongoDB.Driver;
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    [Route("api/data")]
    public class APITestController : Controller
    {
        string filePath = "C:/Personal Projects/ASP-Practice/ASPTestProject/SavedDataJson/data.json";
        string configFilePath = "C:/Personal Projects/ASP-Practice/ASPTestProject/Config/appdata.json";

        private List<Person> people = new List<Person>();


        [HttpPost]
        public IActionResult PostData([FromBody] Person person)
        {



            Console.WriteLine("filePath: " + filePath);
            try
            {

                dynamic response = new
                {
                    message = "Data retrived successfully!",
                };

                _ = SaveNameToJSON(person); //_ = discards the return value.
                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return StatusCode(500, "Internal Server Error");
            }
        }

        public async Task SaveNameToJSON(Person person)
        {

            #region MongoDB Setup
            IConfiguration configuration = new ConfigurationBuilder()
           .AddJsonFile(configFilePath, optional: true, reloadOnChange: true)
           .Build();

            MongoClient mongoClient = new MongoClient(configuration.GetSection("MongoDB:ConnectionString").Value);
            Console.WriteLine("Got the client!");
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase("ASPProject");

            IMongoCollection<Person> mongoDBCollection = mongoDatabase.GetCollection<Person>("personInfo");
            #endregion

            people.Add(person);

            try
            {
                Task BeginSaving = Task.Run(() =>
                    {
                        if (System.IO.File.Exists(filePath))
                        {
                            string oldJsonData = System.IO.File.ReadAllText(filePath);

                            List<Person> priorPeople = JsonConvert.DeserializeObject<List<Person> >(oldJsonData);

                            people.AddRange(priorPeople);
                            Console.WriteLine("Added in the old information");
                        }
                        string jsonData = JsonConvert.SerializeObject(people, Formatting.Indented);
                        System.IO.File.WriteAllText(filePath, jsonData);
                        mongoDBCollection.InsertOne(person); //This way, we're not placing in dupes for old data. 
                        Console.WriteLine("SAVED FILE!");
                    });
                await BeginSaving;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }

    }
}
