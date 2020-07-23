function seeDetails(id) {
    var url = "/Quest/Details?id=" + id;
    location.href = url;
}

function searchQuests() {
    var url = $("#inputTextForSearch").val();
    console.log(res);
    location.href = "Quest/Search?name=" + url;
}
