	//translate
    $("p").delegate("span", "click", function(event){
        var text=event.target.innerText.replace(',','').replace('.','').replace("-"," ")
        $.ajax('https://tureng.com/tr/turkce-ingilizce/'+text,{            
        success: function (data) {    // success callback function
            $(".toast-body").html($(data).find('#englishResultsTable > tbody > tr:nth-child(4) > td.tr.ts > a')[0].innerText)}});
        $("#liveToast").toast("show");
    });