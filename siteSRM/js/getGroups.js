// Projet: M306_SRM
// Script: Script js/ajax getGroups.js
// Description: endpoint de récupération de la table roles.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 01.03.2021, version initial

let id = 10;

callData(id)

function callData(userID) {
    const URL = "getGroups.php?userID=" + userID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById("list-groups").innerHTML = this.responseText;
            }
            else {
                console.error(this.status + " when call " + URL);
                alert(this.status);
            }
        }
    };
    xhttp.open("GET", URL, true);
    xhttp.send();
}