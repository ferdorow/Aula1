$(document).ready(
    function () {
        /* Chamamos nossa fun��o de intervalo */
        atualizaData();
    });
/* Criamos nossa primeira fun��o */
function atualizaData() {
    /*Agora adicionamos a fun��o dentro da context do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
    
}