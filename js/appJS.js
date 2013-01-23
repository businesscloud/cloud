function showBackground(obj) {
    obj.style.background = 'rgba(255,255,255,0.5)';
    if (obj.getElementsByClassName) {
       var actions = obj.getElementsByClassName("actions");
       actions[0].style.visibility = 'visible';
    }
    else
        alert("action is null");
}

function hideBackground(obj) {
    obj.style.background = null;
    var actions = obj.getElementsByClassName("actions");
    actions[0].style.visibility = 'hidden';
}

function gotoLink(link) {
    window.location = link;

}

function deleteApp(obj) {
    var appID = obj.id;
    $.post("bgdata/DeleteApp.aspx", { ID: appID }, function (data) {
        if (data == "true")
            document.location.reload(true);
        else
            alert("Error!");
    });
}

function addApp(obj) {
    var appID = obj.id;
    $.post("bgdata/AddApp.aspx", { appID: appID }, function (data) {
        if (data == "true") {
            document.location.reload(true);
        }
        else
            alert("Error!");
    });
}

function changeWallpaper(pic) {
    $('body').css('background-image', 'url(\'img/wallpaper/'+pic+'\')');
}