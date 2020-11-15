// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    jQueryModalGet = (url, title) => {
        try {
            $.ajax({
                type: 'GET',
                url: url,
                dataType: "html",
                success: function (res) {
                    $('#form-modal .modal-body').html(res);
                    $('#form-modal .modal-title').html(title);
                    $('#form-modal').modal('show');
                },
                error: function (err) {
                    console.log(err)
                }
            });
        } catch (ex) {
            console.log(ex)
        }
        return false;
    }
    jQueryModalPost = form => {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                dataType: "html",
                success: function (res) {
                    $('#viewAll').html(res);
                    $('#form-modal').modal('hide');
                },
                error: function (err) {
                    console.log(err);
                }
            });
        } catch (ex) {
            console.log(ex);
        }
        return false;
    }
    jQueryModalDelete = url => {
        if (confirm('本当に削除してもよろしいですか?')) {
            try {
                $.ajax({
                    type: 'POST',
                    url: url,
                    dataType: "html",
                    contentType: false,
                    processData: false,
                    success: function (res) {
                        $('#viewAll').html(res);
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });
            } catch (ex) {
                console.log(ex);
            }
        }
        return false;
    }
});