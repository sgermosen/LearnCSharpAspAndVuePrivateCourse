function loadContact(contactId) {
    if (contactId == undefined) { contactId = $('#ContactId').val(); }

    $.ajax({
        url: `https://localhost:7224/api/Contacts/${contactId}`,
        type: 'GET',
        success: function (contact) {
            $('#Name').text(contact.name);
            $('#LastName').text(contact.lastName);
            $('#Address').text(contact.address);
            $('#Email').text(contact.email);
            $('#Phone').text(contact.phone);
        },
        error: function (error) {
            console.log(error);
            alert('Ocurrió un error al cargar los datos del contacto');
        }
    });
}