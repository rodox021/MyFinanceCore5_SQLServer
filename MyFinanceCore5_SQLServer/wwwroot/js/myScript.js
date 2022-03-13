function teste(id) {
    var op = confirm("Sure?" + id)
    alert(op)
}

function deleteTypePayment(id) {

    var op = confirm(
        "Tem ceretza que deseja excluir esse tipo de pagamento? " + id
    )

    if (op) {
       alert(op)

        $.ajax({
            type: "POST",
            url: "/PictureIcons/Delete",
            data: { "id": id },
            success: function () {
                alert("ok")
            },
            error: function (res) {
                alert(res.responseText);
            }
            
        })
    }

}