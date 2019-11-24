
$(document).ready(function () {
    $('input[name="btnCadastrar"]').click(function () {
        var cadastros = $('form[name="Cadastro"]').serializeArray();

        $.post("http://localhost:62588/api/Usuarios", cadastros, function (data) {
            alert("teste");
        });

    });
});