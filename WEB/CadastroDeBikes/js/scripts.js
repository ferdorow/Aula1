$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var marca = $('input[name=marca]').val();
				var valor = $('input[name=valor]').val();
				var peso = $('input[name=peso]').val();

				alert("Bike da marca: " + marca +
				" - valor R$: "+ valor +
				" - peso Kg: " + peso +
				" - Cadastrada com Sucesso!");
                
            });
    });
				