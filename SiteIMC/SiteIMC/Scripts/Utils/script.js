$(document).ready(function () {
    //adiciona uma função ao click do botao
    $('input[name="bntconsultar"]').click(function () {
        //obter as informações dos meus campos
        //Obtemos as informações do nosso formulario web completo
        var informacoes = $('form[name="formenviar"]').serializeArray();
   
        $.post("http://localhost:56907/api/Imc", informacoes, function (data) {
            //aqui como recebemos uma string com formato de JSON
            //temos que passar ela para o JSON parecido com o int.Parse 
            alert(data);
        });

    });
});