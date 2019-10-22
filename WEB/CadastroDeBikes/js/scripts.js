$(document).ready(
    function () {
        $('input[name="salvar"]').click(
            function () {
                var marca = $('input[name=marca]').val();
				var valor = $('input[name=valor]').val();
				var peso = $('input[name=peso]').val();

			var magrela = { marca: marca, valor: valor, peso: peso}

			alert("Bike cadastrada com sucesso!")
			LimparTela();

			$('input[name="mostrar"]').click(
            function () {
                $('input[name=marca]').val(magrela.marca);
				$('input[name=valor]').val(magrela.valor);
				$('input[name=peso]').val(magrela.peso);

				alert("Bike da marca: " + marca +
				" - valor R$: "+ valor +
				" - peso Kg: " + peso +
				" - Cadastrada com Sucesso!");
            });     
        }); 
    });
		
		function LimparTela() {
    var meusInputs = $('input[type="text"],input[type="number"]');
    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }

}