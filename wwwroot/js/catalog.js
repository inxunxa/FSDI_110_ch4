

function getCatalogData() {
    // create a jquery ajax request 
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: function (res) {
            console.log("Server says", res);
        },
        error: function (error) {
            console.log("Erron getting catalog", error);
        }
    });
}


function init() {
    console.log("I'm catalog page");

    getCatalogData();
}


window.onload = init;