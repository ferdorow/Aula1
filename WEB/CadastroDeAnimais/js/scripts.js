$(document).ready(
    function () {
        $('input[name="salvar"]').click(
            function () {
                var nome = $('input[name=nome]').val();
                var idade = $('input[name=idade]').val();
                var raca = $('input[name=raca]').val();
                var coloracao = $('input[name=coloracao]').val();

                var doguinho = { nome: nome, idade: idade, raca: raca, coloracao: coloracao }

				alert("Dog cadastrado com sucesso!")

                LimparTela();

                $('input[name="mostrar"]').click(
                    function () {
                        $('input[name=nome]').val(doguinho.nome);
                        $('input[name=idade]').val(doguinho.idade);
                        $('input[name=raca]').val(doguinho.raca);
                        $('input[name=coloracao]').val(doguinho.coloracao);

                        alert("Doguinho, chamado " + nome +
                            " - idade: " + idade +
                            " - raca: " + raca +
                            " - coloracao: " + coloracao +
                            " - Cadastrado com Sucesso!")
                    });

            });
    });

function LimparTela() {
    var meusInputs = $('input[type="text"],input[type="number"]');
    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }

}