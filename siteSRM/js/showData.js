// Projet: M306_SRM
// Script: Script js showData.js
// Description: les fonctions d'affichage des données.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 29.03.2021, version initial

function showLoadingScreen() {
    document.getElementById("discussion-page").innerHTML = displayLoadingScreen();
}

function showNormalScreen() {
    document.getElementById("discussion-page").innerHTML = displayNormalScreen();
}

function showLoadingMessage() {
    document.getElementById("list-messages").innerHTML = displayLoadingScreen();
}

function showGroups() {
    document.getElementById("list-groups").innerHTML = displayGroupsList(listGroups);
}

function showChannels(groupID) {
    activeGroup = groupID;
    var group = listGroups.find(obj => {return obj.id === groupID})
    document.getElementById("list-channels").innerHTML = displayChannelsList(groupID, group['channels']);
}

function showMessages(messages) {
    var messageBody = document.getElementById("list-messages");
    messageBody.innerHTML = displayMessagesList(messages);
    messageBody.scrollTop = messageBody.scrollHeight - messageBody.clientHeight;
}

function showNewMessages(new_messages) {
    var messageBody = document.getElementById("list-messages");
    messageBody.innerHTML += displayMessagesList(new_messages);
    messageBody.scrollTop = messageBody.scrollHeight - messageBody.clientHeight;
}

function showMessageSender(receiverGroupID, receiverChannelID) {
    document.getElementById("message-sender").innerHTML = displayMessageGroupSender(receiverGroupID, receiverChannelID);
}