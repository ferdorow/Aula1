$(document).ready(function () {
         $('input[type="button"]').click(
         function () {
                 var cep = $('input[name="cep"]').val();

                 $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data) {

                     if (data.erro) {
                         alert("CEP Inv�lido");
                         return false;
                     }

                    $('input[name="cep"]').val(data.cep);
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="complemento"]').val(data.complemento);
                    $('input[name="gia"]').val(data.gia);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="unidade"]').val(data.unidade);
               
                });
         });
 });