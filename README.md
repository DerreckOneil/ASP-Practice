# ASP-Practice
# Goals, Documentation and Issues faced:
## Goals:
* Study ASP.NET
* Study HTML
* Print information
* Get information via text field
* Print the text directly below
* Study SQL and integrate new data from MS SQL server object explorer
* Study dependency injection and what makes it work
## Setup: Core ASP vs ASP.NET Framework and containers. 
* Ensure you're running a regular visual studio gitignore.
* Here's what they don't tell you :)
  1. Core ASP is compatible with .NET 6+ while ASP.NET Framework is only compatible with 4.7 versions which is quite old. I personally chose to do a ASP.Net core web app simply because of that issue.
  2. **Windows 11 users beware!** For Razor pages, it **MUST** be ran using windows containers or else you will see issues within the page!!!
  3. Why though? Because Docker linux is compatible with Windows 11 Enterprise.
  4. Why do we care? If you're running a Docker Linux container, you cannot run the page with the data you've integrated via script, sql file, etc.
  5. How do we fix this? Don't use docker and ensure it's unchecked when you create the project. Run the default windows container and test the site via `ctrl+F5`.

## Documentation (NOTE, this is going to match the guide):
1. I followed the ASP.NET guide given by Microsoft. Link[https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-7.0&tabs=visual-studio]
2. Added a data model in C# ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/7ea9e2c0-4ac5-4865-8c3c-a6595e612884)
3. I created a Razor page named Movies via add new scaffold item and ensured that the Model class and the database provider was accurate. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/6f2818f1-b04f-42f6-b680-a95797f62ab1)
4. Updated the database via PMC within the NuGet Package Manager NOTE: **DO NOT SKIP THIS STEP!** ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/74a192ad-87b5-4d8b-b4c4-746cba8b2cbc)
5. Created the property for the entity set (the database table)![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/2865cc99-3dec-4518-8df8-9407d719d50f)
* Now within the webbar, you have to type in the specific page name. Note: save yourself some trouble and use Edge or perhaps Chrome...Firefox cannot establish a connection...*
* Feel free to create new pieces of data here. Additionally, you can edit the data via C# with the SeedData script mentioned within the MS tutorial.
## Now here's where things got tricky. Issues mentioned here: 
1. Working with a database.
  * When you open SQL Server Object Explorer, you can see a bunch of files and stuff. Ensure you're looking at the correct database.
  * How? Print it to the console via C# script. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/0059f13f-5ece-4334-8762-8d5dffc814f0)
  * I'm still confused as to what the name is. Where do I go to find it? You'll find it in the console.exe ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/29b865d8-b2bc-4e98-8416-795f6595d93e) ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/c2e114b9-5716-4c01-adc0-34f62bc5c21c)
  * Now you should be able to see your fields. Welcome to the beginning. What it opens by default is a T-SQL file based on your localdatabase. Lots more on this later.
  * Later has now arrived. Buckle your seatbelts because now it's time for the hard stuff.
## Working with T-SQL
1. Here's how you can pull up the screen.
  * Go to View > SQL Server Object Explorer.
  * Then view The local DB MSSQL in the SQL server via the name MSSQLLocalDb within databases, go to the proper database using the drop down button. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/8c65fd82-08d9-421b-bffe-19bbf9b91bcd)
  * Double click the table name with the icon and note the DB name (**You'll need this later!!!**) ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/200c891c-8bb6-4728-8403-0d9d1d07e38f)
  * Boom, the screen shows as expected. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/77d66cc4-0ab3-4384-9cfe-a4ae2facd4f6)
  * Right click on the table name and select view data to see what's already in the Razor page. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/bff7cfd0-c044-484b-a407-5b45ae6e5de8)
  * Then from here you can select the script button towards the top. ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/a5d617fc-90ae-4621-92f7-7ee5c818bfdf)
  * From here you can insert more data. Feel free to take this further, I decided to download VS Code's extension: [https://learn.microsoft.com/en-us/sql/tools/visual-studio-code/sql-server-develop-use-vscode?view=sql-server-ver16]
  * From here you'll need to add a connection to a SQL server...this is where things get tricky too.
  * Select the plus to add a connection. Remember I said you'll need the DB name? Well now you do.
  * We're gonna use the host name and instance. You can find it here: ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/15a0a99d-e387-408e-bf56-5aa018dbb99b)
  * Place that into the field and then press enter. Then press enter again for the next optional field and then select integrated ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/6ea9f03a-0477-43f3-a71d-a3f4a162d597)
  * This worked for me, results may very, but it will take a few tries to get this set up. Believe me it's worth the set up.
  * In VS Code, you can now see your database and add data via sql scripts and show the data. Be sure to utilize the USE statement to use your table.
  * Now you can use your MS SQL statements as such: ![image](https://github.com/DerreckOneil/ASP-Practice/assets/46698382/b838abf6-f729-4dd6-9054-aad74e19217f)
## Congrats, you've now integrated SQL within your ASP.NET project!










   
