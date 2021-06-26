// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    var indexTitle = $('#TilteHere');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            indexTitle.html(data);
            indexTitle.find('.modal').modal('show');
        })
    })
    indexTitle.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            indexTitle.find('.modal').modal('hide');
        })
    })
})

$(function () {
    var pagetask = $('#PageTaskHere');
    $('button[data-toggle="tasksmodal"]').click(function (event) {
        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {
            pagetask.html(data);
            pagetask.find('.modal').modal('show');
        })
    })
    pagetask.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            pagetask.find('.modal').modal('hide');
        })
    })

})