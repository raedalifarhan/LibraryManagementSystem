



$(document).ready(function () {
    $('#category').attr('disabled', true);
    $('#subcategory').attr('disabled', true);
    $('#books').attr('disabled', true);

    LoadCategories();

    $('#category').change(function() {
        var CategoryId = $(this).val();

        if (CategoryId > 0) {
            LoadSubCategories(CategoryId);
        } else {
            alert("Select Category");
            
            $('#subcategory').empty();
            $('#books').empty()

            $('#subcategory').attr('disabled', true);
            $('#books').attr('disabled', true);
            $('#subcategory').append('<option>--Select Category--</option>');
            $('#books').append('<option>--Select SubCategory--</option>');
        }
    });


    $('#subcategory').change(function() {
        var SubCategoryId = $(this).val();

        if (SubCategoryId > 0) {
            LoadBooks(SubCategoryId);
        } else {
            alert("Select Sub Category");
            
            $('#books').empty()

            $('#books').attr('disabled', true);
            $('#books').append('<option>--Select SubCategory--</option>');
        }
    });


});

function LoadCategories() {
    $('#category').empty();

    $.ajax({
        url: '/Books/GetCategories',
        success: function(response) {
            if (response != null && response != undefined && response.length > 0 ) {
                $('#category').attr('disabled', false);
                $('#category').append('<option>--Select Category--</option>');
                $('#subcategory').append('<option>--Select SubCategory--</option>');
                $('#books').append('<option>--Select Books--</option>');
                $.each(response, function(i, data) {
                    $('#category').append('<option value='+data.id+'>'+data.name+'</option>');
                });
            } else {
                $('#category').attr('disabled', true);
                $('#subcategory').attr('disabled', true);
                $('#books').attr('disabled', true);

                $('#category').append('<option>--Category Not Available--</option>');
                $('#subcategory').append('<option>--SubCategory  Not Available--</option>');
                $('#books').append('<option>--Books  Not Available--</option>');
            }
        },
        error: function(error) {
            alert(error);
        }
    });
}

function LoadSubCategories(CategoryId) {
    $('#subcategory').empty();
    $('#books').empty()
    $('#books').attr('disabled', true);

    $.ajax({
        url: '/Books/GetSubCategories?Id=' + CategoryId,
        success: function(response) {
            if (response != null && response != undefined && response.length > 0 ) {
                $('#subcategory').attr('disabled', false);
                $('#subcategory').append('<option>--Select SubCategory--</option>');
                $('#books').append('<option>--Select Books--</option>');
                $.each(response, function(i, data) {
                    $('#subcategory').append('<option value='+data.id+'>'+data.name+'</option>');
                });
            } else {
                $('#subcategory').attr('disabled', true);
                $('#books').attr('disabled', true);

                $('#subcategory').append('<option>--SubCategory  Not Available--</option>');
                $('#books').append('<option>--Books  Not Available--</option>');
            }
        },
        error: function(error) {
            alert(error);
        }
    });
}

function LoadBooks(SubCategoryId) {
    $('#books').empty();

    $.ajax({
        url: '/Books/GetBooks?Id=' + SubCategoryId,
        success: function(response) {
            if (response != null && response != undefined && response.length > 0 ) {
                $('#books').attr('disabled', false);
                $('#books').append('<option>--Select Books--</option>');
                $.each(response, function(i, data) {
                    $('#books').append('<option value='+data.id+'>'+data.title+'</option>');
                });
            } else {
                $('#books').attr('disabled', true);
                $('#books').append('<option>--Books  Not Available--</option>');
            }
        },
        error: function(error) {
            alert(error);
        }
    });
}