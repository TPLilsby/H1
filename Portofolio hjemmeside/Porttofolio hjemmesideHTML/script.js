//Cv function
$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetCv"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('.cv-title').append(data[i].title);
            $('.cv-description').append(data[i].description);
            $('#cv-image').attr("src", data[i].image_path)
            $('#pdf-link').attr("href", data[i].pdf_link);
        }
    });
});

//Project
$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetProject"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('#project').append('<h1 class="pt-4">' + data[i].title + '</h1>');
            $('#project').append('<h4>' + data[i].description + '</h4>');
            $('#project').append('<img class="resize" src="' + data[i].image_path + '">');
            $('#project').append('<a target="_blank" href="' + data[i].github_link + '"><button class="download-button m-lg-4">GitHub Link</button></a>');
        }
    });
});

$(document).ready(function() {
    $.ajax({
        url: "https://localhost:7073/GetContact"
    }).then(function(data) {
        for (i = 0; i < data.length; i++) {
            $('#contact').append('<h5 class="pt-4">First Name: ' + data[i].first_name + '</h5>');
            $('#contact').append('<h5>Last Name: ' + data[i].last_name + '</h5>');
            $('#contact').append('<h5>Email: ' + data[i].email + '</h5>');
            $('#contact').append('<h5 class=" resize pt-4"> Text: ' + data[i].text + '</h5>');
        }
    });
});

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