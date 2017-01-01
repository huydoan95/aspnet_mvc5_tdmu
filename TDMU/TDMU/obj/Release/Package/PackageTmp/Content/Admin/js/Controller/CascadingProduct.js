
$(function () {
    $.ajax({
        type: "GET",
        url: "/Cart/GetCategory",
        datatype: "Json",
        success: function (data) {
            $.each(data, function (index, value) {
                $('#category').append('<option value="' + value.ID + '">' + value.Name + '</option>');
            });
        }
    });

    $('#category').change(function () {

        $('#product').empty();

        $.ajax({
            type: "POST",
            url: "/Cart/GetProductByCatID",
            datatype: "Json",
            data: { cat_id: $('#category').val() },
            success: function (data) {
                $.each(data, function (index, value) {
                    $('#product').append('<option value="' + value.ID + '">' + value.Name + '</option>');
                });
            }
        });
    });

    
});
