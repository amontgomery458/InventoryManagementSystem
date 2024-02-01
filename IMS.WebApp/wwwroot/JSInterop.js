function PreventFormSubmission(formId) {
    document.getElementById(formId).addEventListener("keydown", function (event) {
        if (event.keyCode == 13) {
            event.preventDefault();
            return false;
        }
    })
}