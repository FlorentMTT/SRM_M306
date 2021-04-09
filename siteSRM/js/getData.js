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
                listGroups = JSON.parse(this.responseText);
                showNormalScreen();
                showGroups();
                console.log(listGroups);
                showChannels(listGroups[0]['id']);
                callMessages(listGroups[0]['id'], listGroups[0]['channels'][0]['id'])
            }
            else {
                console.error(this.status + " when call " + URL);
                alert(this.status);
            }
        }
    };
    showLoadingScreen();
    xhttp.open("GET", URL, true);
    xhttp.send();
}

// Récupère les messages du channel sous format json
function callMessages(channelID) {
    activeChannel = channelID;
    const URL = "api/getMessages.php?channelID=" + channelID;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                var messages = JSON.parse(this.responseText);
                nbMessages = messages['count'];
                startChecker();
                showMessages(messages['messages']);
            }
            else {
                console.error(this.status + " when call " + URL);
                alert(this.status);
            }
        }
    };
    stopChecker();
    showLoadingMessage();
    showMessageSender(activeGroup, activeChannel);
    xhttp.open("GET", URL, true);
    xhttp.send();
}

// Récupère les nouveaux messages du channel sous format json
function callNewMessages(channelID, nbMessagesToGet) {
    console.log(nbMessagesToGet);
    const URL = "api/getNewMessages.php?channelID=" + channelID + "&nbMessages=" + nbMessagesToGet;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                var new_messages = JSON.parse(this.responseText);
                showNewMessages(new_messages);
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

function sendMessageUser(senderUserID, receiverUserID) {

}

// Envoi d'un message d'un utilisateur vers un group/channel
function sendMessageGroup(senderUserID, receiverGroupID, receiverChannelID) {
    const URL = "api/postMessageToGroup.php";
    const form = document.getElementById('form-send-message');

    let formData = new FormData(form);
    formData.append('senderUserID', senderUserID);
    formData.append('receiverGroupID', receiverGroupID);
    formData.append('receiverChannelID', receiverChannelID);

    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                document.getElementById('content').value = "";
            }
            else {
                console.error(this.status + " when call " + URL);
                alert(this.status);
            }
        }
    };
    xhttp.open("POST", URL, true);
    xhttp.send(formData);
}

// Verifie si il y a de nouveau messages
function checkNewMessages() {
    const URL = "api/getCountMessages.php?channelID=" + activeChannel;
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == XMLHttpRequest.DONE) {
            if (this.status == 200) {
                newNbMessages = JSON.parse(this.responseText);
                if (nbMessages < newNbMessages) {
                    callNewMessages(activeChannel, (newNbMessages - nbMessages));
                    nbMessages = newNbMessages;
                }
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

// Lance le vérificateur de nouveaux messages
function startChecker() {
    messageGetter = setInterval(checkNewMessages, 1000)
}

// Termine le vérificateur de nouveaux messages
function stopChecker() {
    clearInterval(messageGetter)
}