'use_strict';
(function () {
    let articleSet = new Array(document.getElementsByClassName("article"));
    for (let i = 0; i < articleSet[0].length; i++) {
        el = articleSet[0][i]; 
        el.style.height = "0%";
        el.style.fontSize = "0%";;
    }
})()

function openNav() {
    document.getElementById("myNav").style.width = "100%";
}

function closeNav() {
    document.getElementById("myNav").style.width = "0%";
}

function showHideArticle(articleId) {
    let el = document.getElementById(articleId);
    if (el.style.height == "0%") {
        el.style.height = "100px";
        el.style.fontSize = "15px";
    }
    else {
        el.style.height = "0%";
        el.style.fontSize = "0%";
    }
}