$(document).ready(
    function () {
        /* Chamamos nossa função de intervalo */
        atualizaData();
    });
/* Criamos nossa primeira função */
function atualizaData() {
    /*Agora adicionamos a função dentro da context do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
    
}