/*
function changeBackground() {
    const body = document.body;
    if (body) {
        body.style.backgroundImage = 'url("https://upload.wikimedia.org/wikipedia/en/2/27/Bliss_(Windows_XP).png")';
        console.log("Background changed!");
    } else {
        console.error(".center-container element not found");
    }
}

document.addEventListener('DOMContentLoaded', changeBackground);
*/



function onSubmitClick() {
    //screenTxt = value;
    let screenTxt = "";

    //alert("Button pressed: " + value.value);
    screenTxt = document.getElementById('txtfield');
    alert("Button pressed: " + screenTxt.value);

}

function onResetClick() {
    let inputField = document.getElementById('txtfield');
    inputField.value = "";
    //alert("Resetted text.");
}

function onSubmitPersonInfoClick() {

    let firstNameElement = document.getElementById('firstName');
    let lastNameElement = document.getElementById('lastName');
    console.log("Person info has been submitted.");
    console.log("information: " + (firstName.value + " and: " + lastName.value));
    person = new Person(firstName, lastName);

    const dataToSend = {
        firstName: firstNameElement.value,
        lastName: lastNameElement.value,
    };
    fetch('api/data',
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(dataToSend),
        })
        .then(response => {
            response.json();
            console.log("response: " + response.status);
        })
        .then(data => {
            console.log('Data received from the server: ' + data);

        })
        .catch(error => {
            console.error('Error', error);
        });

    firstName.value = "";
    lastName.value = "";

}