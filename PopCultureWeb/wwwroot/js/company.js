var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Company/GetAll"
        },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "streetAddress", "width": "15%" },
            { "data": "city", "width": "15%" },
            { "data": "state", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            {
                "data": "id",
                "width": "15%",
                "render": function (data) {
                    return `<div class=" btn-group" role="group">
                                <a href="/Admin/Company/Upsert?id=${data}" class="btn btn-dark"><i class="bi bi-pen"></i></a>
                                <a onClick=Delete('/Admin/Company/Delete/${data}') class="btn btn-outline-danger"><i class="bi bi-trash3"></i></a>
                            </div>`;
                }
            },
        ]
    });
}

function Delete(url) {
    swal.fire({
        title: "Are you sure you want to delete?",
        text: "You will not be able to recover this record!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#000",
        cancelButtonColor: "red",
        confirmButtonText: "Yes, delete it!",
        dangerMode: true,
    })
    .then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}