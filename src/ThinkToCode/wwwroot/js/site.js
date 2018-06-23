$(function () {
    function pageLoad() {
        loadComments();
        BindControl();
    }
    function loadComments() {
        var key = $("#key").val();
        $.get("/Comment/GetCommnets", { id: key }, function (data) {
            var htmlRow = $("#commentTemplate");

            var divComment = $("#divComment");
            if (data.length == 0) {
                $("#noCommnet").show();
            }
            else {
                $.each(data, function (i, j) {
                    var $html = $(htmlRow).clone();
                    $html.find(".mt-0").html(j.userName);
                    $html.find(".media-body").append(j.comment);
                    divComment.append($html.html());
                });
            }








        });
    }
    function BindControl() {
        $("#btnSubmit").click(function () {
            var txt = $("#txtDescription");
            if (txt.val() == "") {
                txt.addClass("has-error");
            }
            else {
                txt.removeClass("has-error");
                $.post("/Comment/post", { id: $("#key").val(), comment: txt.val() })
            }
        });
    }

    pageLoad();
});