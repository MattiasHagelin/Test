function editModal(id, firstname, lastname) {
    //document.location = 'index.aspx?id=' + id + '&mode=edit';
    $("h4.modal-title").text(firstname + " " + lastname);
    //$("#firstname").val(firstname);
    //$("#lastname").val(lastname);
    $("#cphMain_tbVfirstname").val(firstname).show();
    $("#cphMain_tbVlastname").val(lastname).show();
    $("#cphMain_tbVid").val($("#" + id).attr('id'));
    $("#cphMain_tbVId").val(id);
    $("#cphMain_btnAdd").hide();
    $("#cphMain_btnEdit").show();
    $("#cphMain_btnDelete").hide();
    $("#myModal").modal();
}

function deleteModal(id, firstname, lastname) {
    $("h4.modal-title").text('Delete ' + firstname + " " + lastname);
    $("#modal_mode").val("delete");
    $("#cphMain_tbVid").val($("#" + id).attr('id'));
    $("#cphMain_tbVId").val(id);
    $("#cphMain_tbVfirstname").hide();
    $("#cphMain_tbVlastname").hide();
    $("#cphMain_btnAdd").hide();
    $("#cphMain_btnEdit").hide();
    $("#cphMain_btnDelete").show();


    $("#myModal").modal();
}

function addContact() {

    $("h4.modal-title").text('Add new contact');

    $("#cphMain_tbVfirstname").val('').show();
    $("#cphMain_tbVlastname").val('').show();
    $("#cphMain_btnAdd").show();
    $("#cphMain_btnEdit").hide();
    $("#cphMain_btnDelete").hide();
    $("#myModal").modal();
}