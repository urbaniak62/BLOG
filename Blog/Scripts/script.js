$(document).ready(function () {
   
});

function verifier(id, labelId, type, btn_Submit) {
    var txt = $("#MainContent_" + id).val();
    
    if (txt == "" || txt.length == 1) {
        alert("personne");
        $("#MainContent_" + labelId).html("veuillez verifier les champ");
    }
    else if (type == 'email') {
        if (!validateEmail(txt)) {
            $("#MainContent_" + labelId).html("le champ email n'est pas valide");
        }
        else {
            $("#MainContent_" + btn_Submit).removeAttr("disabled");
        }
    }
}
function validateEmail(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}