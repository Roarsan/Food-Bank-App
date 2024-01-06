// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    const darkModeSwitch = document.getElementById('darkModeSwitch');

    darkModeSwitch.addEventListener('change', function () {
        document.body.classList.toggle('dark-mode', darkModeSwitch.checked);
    });
});
