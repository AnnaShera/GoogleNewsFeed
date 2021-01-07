function extrect(rssFeedId) {
    //Removes previous rss element data from right side of the screen
    $('#title').remove();
    $('#description').remove();
    $('#linkToOrigin').remove();
    //Repopulate right side of the screen with data retrieved from ajax request according to rssFeedId chosen
    $.ajax({
        url: "WebService.asmx/ExtrectRssData",
        type: "GET",
        data: { rssFeedId: JSON.stringify(rssFeedId) },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: "false",
        success: function (data, status) {
            if (data.d != null) {
                $("<h3 id='title'></h2>").appendTo("#upper");
                $('#title').html(data.d.title)
                $("<p id='description'></p>").appendTo("#upper");
                $('#description').html(data.d.description)
                $("<a id='linkToOrigin'>Read More</a>").attr("href", data.d.link).appendTo("#upper");
            }
        } 
    });
}