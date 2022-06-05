{

    function deleteTypeInput(id) {

        var op = confirm(
            "Tem ceretza que deseja excluir esse tipo de pagamento? "
        )

        if (op) {

            $.ajax(
                {
                    url: 'TypeInput/DeleteJson',
                    method: 'POST',
                    data: { "id": id },
                    async: true,
                    success: function (data) {
                        if (data) {
                            document.getElementById(id).remove();
                            alert("Tipo de entrada excluido com sucesso!!")
                        } else {
                            alert(data)
                        }
                    }
                });
        }
    }
    //----------------------------------------------------
    
}
   