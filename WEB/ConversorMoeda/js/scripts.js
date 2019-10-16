$(document).ready( //aqui ao carregar o documento iniciamos o js
    function () { //este function funciona igual ao new 
        $('input[type="button"]').click( // adicionamos a funcao ao nosso botão
            function () {

                var meuValorReal = $('input[name="real"]').val(); //aqui obtemos o valor ".val(999)" setamos o valor
                var meuValorDolar = 4.16;
                var conversao = meuValorReal / meuValorDolar;

                $('input[name="dolar"]').val(conversao);               
                
            });
    });