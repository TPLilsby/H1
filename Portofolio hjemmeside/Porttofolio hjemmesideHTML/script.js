//Cv function
$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetCv"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('.cv-title').append(data[i].title);
            $('.cv-description').append(data[i].description);
            $('#cv-image').attr("src", data[i].imagePath)
            $('#pdf-link').attr("href", data[i].pdfLink);
        }
    });
});

//Technology function
$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetTechnology"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('#technology').append('<div class="d-flex justify-content-start "><h4 class="pt-4">' + data[i].name+ '</h4><img class="logo-resize" src="' + data[i].logoPath + '"> </div>');
        }
    });
});

//Project function
$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetProject"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('#project').append('<h1 class="pt-4 text-resize">' + data[i].title + '</h1>');
            $('#project').append('<h4 text-resize>' + data[i].description + '</h4>');
            $('#project').append('<img class="resize" src="' + data[i].imagePath + '">');
            $('#project').append('<a target="_blank" href="' + data[i].githubLink + '"><button class="download-button m-lg-4">GitHub Link</button></a>');
        }
    });
});

// Contact
$(document).ready(function () {
    $("#contactform").submit(function (event) {
      var formData = {
        FirstName: $("#fname").val(),
        LastName: $("#lname").val(),
        Email: $("#email").val(),
        Text: $("#text").val()
      };
  
      $.ajax({
        type: "POST",
        url: "https://localhost:7073/SubmitContact",
        data: JSON.stringify(formData),
        contentType: "application/json; charset=utf-8",
        }).done (function (data) {
            console.log(data);
        })
        .fail (function (data) {
          
            console.log(data)
          
        })
  
      event.preventDefault();
    });
  });