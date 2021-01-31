$(document).on('ready', function () {
    alert("ready");
    onScrollLoading();



});


function fetchData(top, skip) {
    var jsonData = JSON.stringify({
        top: top,
        skip: skip
    });
    debugger;
    $.ajax({
        url: '/api/Temple/GetTemples',
        type: 'POST',
        data: jsonData,
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            debugger;
            for (var i = 0; i < result.queryTempleContents.length; ++i)
            {
  
                 $("#infinite-list").append("<h3>" + result.queryTempleContents[i].flatData.name + "</h3>");
       
            }

        },
        error: function () {
            $("#msg").html("Error while calling the Web API!");
        }
    });
}


function onScrollLoading() {
    debugger;
    var listElm = document.querySelector('#infinite-list');
    var loadingElm = document.querySelector('#infinite-list .loading');

  

    // Add 20 items.
    var nextItem = 1;
    var loading = false;
    var loadMore = function () {
        // Should only start loading more items if it's not already loading some.
        if (loading) {
            return;
        }

        // Show loading icon.
        loading = true;
        loadingElm.style.visibility = '';
    }

  
    $(window).scroll(function () {
        debugger;
        
        if ($(window).scrollTop() == $(document).height() - $(window).height()) {
            {
                loadingElm.style.visibility = '';
                var loading = true;
             
                fetchData(3, 3);
                loading = false;
                loadingElm.style.visibility = 'hidden';
            }
        }
    });
      

    debugger
     // Initially load some items.
     fetchData(3, 0);
}