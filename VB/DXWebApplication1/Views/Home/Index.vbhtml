<script type="text/javascript">
    function SetButtonsVisibility(s) {
        var statusBar = s.GetMainElement().getElementsByClassName("StatusBarWithButtons")[0].getElementsByTagName("td")[0];
        if (!s.batchEditApi.HasChanges())
            statusBar.style.visibility = "hidden";
        else
            statusBar.style.visibility = "visible";
    }

    function OnCustomButtonClick(s, e) {
        if (e.buttonID == "deleteButton") {
            s.DeleteRow(e.visibleIndex);
            SetButtonsVisibility(s);
        }
    }
    function OnBatchEditEndEditing(s, e) {
        window.setTimeout(function () { SetButtonsVisibility(s); }, 0);
    }
</script>

<form>
    @Html.Action("GridViewPartial")
</form>
<br />
