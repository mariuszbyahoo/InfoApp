'use_strict';
function openNav() {
    document.getElementById("myNav").style.width = "100%";
}

function closeNav() {
    document.getElementById("myNav").style.width = "0%";
}

function showHideArticle(articleId) {
    let el = document.getElementById(articleId);
    if (el.style.height == "0%") {
        el.style.height = "150px";
        el.style.fontSize = "15px";
    }
    else {
        el.style.height = "0%";
        el.style.fontSize = "0%";
    }
}