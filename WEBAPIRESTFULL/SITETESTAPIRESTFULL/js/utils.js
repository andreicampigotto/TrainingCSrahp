var urlBaseAPi = "http://localhost:59271/Api/"

function buildUrlApi(sendpost, Id = ''){
    if(Id !== '')
        Id = '/' + Id;

    return urlBaseAPi + sendpost + Id;    
}

jQuery(document).ready(function(){
  /* Indica que o evento submit do form irá realizar esta ação agora*/
  jQuery('.form-post').submit(function(){
      /* Neste contesto 'this' representa o form deste ID  #myform */  
      var Id = $($(this)[0][1]).val();            
      var dados = $(this).serialize();
      var sendpost = $(this).attr('send-post');
      var callStr  = $(this).attr('call');
      var method = "POST";

      if(Id !== "") {
          method = "PUT";
          Id = "/"+Id;
      }

       var settings = {
        "crossDomain": true,
        "url": buildUrlApi(sendpost, Id),
        "method": method,
        "headers": {
          "Content-Type": "application/x-www-form-urlencoded",
          "Accept": "*/*"
        },
        "data": dados
      }

      $.ajax(settings).done(function (response) {
         window[callStr](response);
      });
      $.each(this,function(index,value){
        $('[name=\''+value.name+'\']').val("");
      });
      
      return false;
  });
  jQuery('.btn-cancel-form').click(function(){
    var form = $(this).parent().parent().parent()[0];
    
    $.each(form,function(index,value){
        $('[name=\'' + value.name + '\']').val("");
    });
  });
});

function SetGridClickEvents(){
  $('.btn-delet-event').click(function(){
      var Id = $(this).attr('value');
      var sendpost = $(this).attr('send-post');

      var settings = {
          "crossDomain": true,
          "url": buildUrlApi( sendpost, Id),
          "method": "DELETE",
          "headers": {
            "Content-Type": "application/x-www-form-urlencoded",
            "Accept": "*/*"
          }
        }

        $.ajax(settings).done(function (response) {
            GetMethod(null);
        });
  });
  $('.btn-editing-event').click(function(){
    if($('#collapse-btn')[0].innerHTML.indexOf('fa-plus') > -1 )
        $('#collapse-btn').click();  
    
    var Id = $(this).attr('value');
      var sendpost = $(this).attr('send-post');

      var settings = {
        "crossDomain": true,
        "url": buildUrlApi( sendpost, Id),
        "method": "GET",
        "headers": {
          "Content-Type": "application/x-www-form-urlencoded",
          "Accept": "*/*"
        }
      }
      $.ajax(settings).done(function (response) {
        $.each(response,function(index, value){
            $('input[name="' + index + '"]').val(value);
            $('select[name="'+ index + '"]').val(value);
        });
        $('btnCancelar').show();
    });

  });
}