// Projet: M306_SRM
// Script: Script js/ajax getData.js
// Description: les fonctions d'appel de l'api.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 01.03.2021, version initial
function callGroups() {
    let userID = document.getElementById('hidden_user_id').value;
    const URL = "api/getGroups.php?userID=" + userID;
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

function callChannels(groupID) {
    const URL = "api/getChannels.php?groupID=" + groupID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById("list-channels").innerHTML = this.responseText;
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

function callMessages(channelID) {
    const URL = "api/getMessages.php?channelID=" + channelID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById("list-messages").innerHTML = this.responseText;
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

function sendMessageUser(content, senderUserID, receiverUserID) {
    const URL = "api/postMessageGroup.php?content=" + content + "&senderUserID=" + senderUserID + "&receiverUserID=" + receiverUserID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById("list-messages").innerHTML = this.responseText;
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

function sendMessageGroup(content, senderUserID, receiverGroupID, receiverChannelID) {
    const URL = "api/postMessageGroup.php?content=" + content + "&senderUserID=" + senderUserID + "&receiverGroupID=" + receiverGroupID + "&receiverChannelID" + receiverChannelID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById("list-messages").innerHTML = this.responseText;
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