// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(window).load(function () {
    // ADD BOLD ELEMENTS
    $('.bother:contains("MNOs")').each(function () {
        $(this).html(
            $(this).html().replace(/MNOs/g, '<strong>$&</strong>')
        );
    });
    $('.bother:contains("Cable Tv")').each(function () {
        $(this).html(
            $(this).html().replace(/Cable Tv/g, '<strong>$&</strong>')
        );
    });
    $('.bother:contains("Power")').each(function () {
        $(this).html(
            $(this).html().replace(/Power/g, '<strong>$&</strong>')
        );
    });
});