//Cv function
$(document).ready(function() {
   
    //Send an AJAX request to retrieve CV data from the specified URL: API Endpoint
    $.ajax({
        url: "https://localhost:7073/GetCv"
    }).then(function(data) {
   
        //Loops through the received data and populate the corresponding elements in the HTML
        for (i = 0; i < data.length; i++) {

            //Append the CV title to elements with the class "cv-title"
            $('.cv-title').append(data[i].title);
            
            //Append the CV description to elements with the class "cv-description"
            $('.cv-description').append(data[i].description);
            
            //Set the source of the image element with the ID "cv-image" to the CV image path
            $('#cv-image').attr("src", data[i].imagePath);
            
            //Set the href of the element with the ID "pdf-link" to the CV PDF link
            $('#pdf-link').attr("href", data[i].pdfLink);
        }
    });
});

//Technology function
$(document).ready(function() {

    //Send an AJAX request to retrieve CV data from the specified URL: API Endpoint
    $.ajax({
        url: "https://localhost:7073/GetTechnology"
    }).then(function(data) {

        //Loops through the received data and dynamically generate HTML elements
        for (i = 0; i < data.length; i++) {

            //Append a container div with a row and two columns to the element with the ID "technology"
            $('#technology').append('<div class="container"> <div class="row"> <div class="col-6"><h4 class="pt-4">' + data[i].name+ '</h4></div> <div class="col-6"> <img class="logo-resize" src="' + data[i].logoPath + '"></div> </div> </div>');
        }
    });
});

//Project function
$(document).ready(function() {
    
    //Send an AJAX request to retrieve CV data from the specified URL: API Endpoint
    $.ajax({
        url: "https://localhost:7073/GetProject"
    }).then(function(data) {

        //Loops through the received data and dynamically generate HTML elements
        for (i = 0; i < data.length; i++) {

            // Append project title
            $('#project').append('<div class="center text-resize"><h1 class="pt-4">' + data[i].title + '</h1></div>');
            
            // Append project description
            $('#project').append('<h4 class="text-resize center">' + data[i].description + '</h4>');
            
            // Append project image element with the ID "project" to the Project image path
            $('#project').append('<img class="resize" src="' + data[i].imagePath + '">');
            
            // Append GitHub link with button element with the ID "project" to the GitHub link
            $('#project').append('<br><a target="_blank" href="' + data[i].githubLink + '"><button class="button m-lg-4">GitHub Link</button></a>');
        }
    });
});

//Contact function
$(document).ready(function() {

    //Triggered when the contact form is submitted
    $("#contactform").submit(function(event) {

        //Retrieve form data
        var formData = {
            FirstName: $("#fname").val(),
            LastName: $("#lname").val(),
            Email: $("#email").val(),
            Text: $("#text").val()
        };

        //Send form data via AJAX POST request
        $.ajax({
            
            //POST
            type: "POST",

            //API Endpoint
            url: "https://localhost:7073/SubmitContact",

            //Convert formData to JSON
            data: JSON.stringify(formData),

            //Specific JSON
            contentType: "application/json; charset=utf-8",

        }).done(function(data) {
            //Sucess calback function
            console.log(data); 

        }).fail(function(data) {
            //Error callback function
            console.log(data);
        });

        //Prevent the default form submission behavior
        event.preventDefault();
    });
});