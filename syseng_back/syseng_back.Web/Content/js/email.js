'use strickt';
$(document).ready( () => {

  let danger_html = "<div id='danger' class='alert alert-danger' role='alert'>Что-то пошло не так! Заполните обязательные поля! <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button></div>";
  let success_html = "<div id='success' class='alert alert-success' role='alert'>Ваше сообщение успешно отправленно! <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button></div>";
  let email_html = "<div id='email_warning' class='alert alert-warning' role='alert'>Поле Email заполненно некорректно! <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button></div>";


  $('body').on('click', '#send', function() {
    $("#danger").remove();
    $("#success").remove();
    $("#email_warning").remove();

    let mail = {
      Name: $('#name')[0].value,
      Email: $('#email')[0].value,
      Body: $('#body')[0].value
    };
    if(!validateEmail(mail.Email))
        $('#contact-block').after(email_html);
    else {
      if(validForm(mail) === true)
        sendForm(mail);
    }
    //valid
  });

  function validateEmail(email) {
      var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      return re.test(email);
  }

function validForm(mail) {
  if(mail.Name === undefined || mail.Body === undefined || mail.Email === undefined )
    return false;
  else
    return true;
}

function sendForm(mail) {
  console.log(213);
  let res = {};
  $.ajax({
      url: 'http://localhost:54502/home/mail',
      type: 'post',
      dataType: 'json',
      success: function (data) {
        if(data == "Ok") {
          $("#danger").remove();
          $("#success").remove();
          $("#email_warning").remove();

          $('#name')[0].value = "";
          $('#email')[0].value = "";
          $('#body')[0].value = "";

          $('#contact-block').after(success_html);
        } else {
          $("#danger").remove();
          $("#success").remove();
          $("#email_warning").remove();
          console.log(123);
          $('#contact-block').after(danger_html);
        }
      },
      data: mail,
      complete: () => {
          //render
      }
  });
}

});
