$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var nome = $('input[name=nome]').val();
                alert("Bom Dia, " + nome + " Seja bem Vindo!");

                alert(teste);

            });
    });
