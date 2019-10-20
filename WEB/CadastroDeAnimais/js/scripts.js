$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var nome = $('input[name=nome]').val();
				var idade = $('input[name=idade]').val();
				var raca = $('input[name=raca]').val();
				var coloracao = $('input[name=coloracao]').val();

                alert("Doguinho, chamado " + nome +
				" - idade: "+ idade +
				" - raca: " + raca +
				" - cor: " + coloracao +
				" - Cadastrado com Sucesso!");
                
            });
    });