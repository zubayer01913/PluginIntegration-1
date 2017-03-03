﻿$(document).ready(function ()
{
    $('#TableId').DataTable(
    {
        "columnDefs": [
            { "width": "5%", "targets": [0] },
            { "className": "text-center custom-middle-align", "targets": [0, 1, 2, 3, 4, 5, 6] },
        ],
        "language":
            {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
        "processing": true,
        "serverSide": true,
        "ajax":
            {
                "url": "/Plugin/GetData",
                "type": "POST",
                "dataType": "JSON"
            },
        "columns": [
                    { "data": "Sr" },
                    { "data": "OrderTrackNumber" },
                    { "data": "Quantity" },
                    { "data": "ProductName" },
                    { "data": "SpecialOffer" },
                    { "data": "UnitPrice" },
                    { "data": "UnitPriceDiscount" }
        ]
    });
});
