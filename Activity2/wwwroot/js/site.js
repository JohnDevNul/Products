﻿$(function () {
    console.log("document is ready");
    $(document).on("click", ".edit-product-button", function () {
        console.log("you just clicked button number " + $(this).val());

        var productID = $(this).val();

        $.ajax({
            type: 'json',
            data: {
                "id": productID
            },
            url: '/products/ShowOneProductJSON',
            success: function (data) {
                console.log(data);

                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }
        })
    });

    $("#save-button").click(function () {

        var Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()

        };

        console.log("saved...");
        console.log(Product);

        $.ajax({
            type: 'json',
            data: Product,
            url: '/products/ProcessEditReturnPartial',
            success: function (data) {
                console.log(data);
                $("#card-number-" + Product.Id).html(data);
            }
        })
    });
});