    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
jQuery(document).ready(function(){
		/* Indica que o evento submit do form irá realizar esta ação agora*/
		jQuery('.form-post').submit(function(){
			/* Neste contesto 'this' representa o form deste ID  #myform */                
        var Id = $($(this)[0][1]).val();
        var dados = $(this).serialize();
        var sendpost = $(this).attr('send-post');
        var callStr = $(this).attr('call');

        if(Id !== "") {
            method = "PUT";
            Id = "/"+Id;
        }
		 var settings = {
		  "crossDomain": true,
		  "url": "https://localhost:59271/Api/" + sendpost,
		  "method": "POST",
		  "headers": {
			"Content-Type": "application/x-www-form-urlencoded",
			"Accept": "*/*"
		  },
		  "data": dados
		}

		$.ajax(settings).done(function (response) {
            window[callStr](response);    /*Vanilla JS*/
		});
			
    	return false;
    });
});

    
