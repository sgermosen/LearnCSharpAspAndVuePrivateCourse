function deleteContact(contactId) {
    if (contactId == undefined || contactId == 0)
    { contactId = $('#ContactId').val(); }

    $.ajax({
        url: `https://localhost:7224/api/Contacts/${contactId}`,
        type: 'DELETE',
        success: function (result) {
            $('#deleteModal').modal('hide');
            window.location.href = '/Contacts/Index'; 
        },
        error: function (error) {
            console.log(error);
            alert('Ocurrió un error al eliminar el contacto');
        }
    });
}