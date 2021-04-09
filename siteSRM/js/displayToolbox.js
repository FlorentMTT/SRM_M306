// Projet: M306_SRM
// Script: Script js displayToolbox.js
// Description: les fonctions de des données.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 29.03.2021, version initial

function displayLoadingScreen() {
    // Initialize
    var output = '';

    // Processing
    output += '<div class="row justify-content-center">';
    output += '<img src="assets/loading/loading.gif" class="col-3" alt="loading gif">';
    output += '</div>';

    // Exit
    return output;
}

function displayNormalScreen() {
    // Initialize
    var output = '';
    
    // Processing
    output += '<div class="row">';
    output += '<ul id="list-groups" class="list-group col-sm-2"></ul>';
    output += '<ul id="list-channels" class="list-group col-sm-2"></ul>';
    output += '<div class="card col-sm-8">';
    output += '<div class="container card-body">';
    output += '<ul id="list-messages" class="list-group" style="height:700px; overflow-y: scroll;"></ul>';
    output += '<div class="row">';
    output += '<div class="cols-sm-10">';
    output += '<form id="form-send-message">';
    output += '<div class="input-group">';
    output += '<input type="text" id="content" name="content" class="form-control"></input>';
    output += '</div>';
    output += '</form>';
    output += '</div>';
    output += '<div id="message-sender" class="col-sm-2"></div>';
    output += '</div>';
    output += '</div>';
    output += '</div>';
    output += '</div>';

    // Exit
    return output
}

function displayGroupsList(data) {
    // Initialize
    var output = '';

    // Processing
    for (var i = 0; i < data.length; i++) {
        output += displayGroup(data[i]);
    }

    // Exit
    return output;
}

function displayGroup(data) {
    // Initialize
    var output = '';

    // Processing
    output += '<li class="list-group-item d-flex justify-content-between align-items-center position-relative">';
    output += '<a onclick="showChannels(' + data['id'] + ')" class="rounded-circle" style="border: solid black 1px">';
    output += '<img src="medias/groups/' + data['profilPictureURL'] + '" class="rounded-circle w-100" alt="' + data['name'] + '">';
    //output += '<span class="badge badge-danger badge-pill position-absolute" style="right:20%; bottom:10%;">1</span>';
    output += '</a>';
    output += '</li>';

    // Exit
    return output;
}

function displayChannelsList(groupID, data) {
    // Initialize
    output = '';

    // Processing
    
    for (var i = 0; i < data.length; i++) {
        output += displayChannel(groupID, data[i]);
    }

    // Exit
    return output;
}

function displayChannel(groupID, data) {
    // Initialize
    var output = '';

    // Processing
    output += '<li class="list-group-item d-flex justify-content-between align-items-center position-relative">';
    output += '<button onclick="callMessages(' + data['id'] + ')" class="btn btn-secondary">' + data['name'] + '</button>';
    output += '</li>';

    // Exit
    return output;
}

function displayMessagesList(data) {
    // Initialize
    var output = '';

    // Processing
    
    for (var i = 0; i < data.length; i++) {
        output += displayMessage(data[i]);
    }

    // Exit
    return output;
}

function displayMessage(data) {
    // Initialize
    var output = '';

    // Processing
    output += '<li class="media">';
    output += '<img style="height: 65px;"  class="mr-3 rounded-circle" src="medias/users/' + data['profilPictureURL'] + '" alt="' + data['name'] + '">';
    output += '<div class="media-body">';
    output += '<h5 class="mt-0">' + data['username'] + '</h5>';
    output += '<p>' + data['content'] + '</p>';
    output += '</div>';
    output += '</li>';

    // Exit
    return output;
}

function displayMessageGroupSender(receiverGroupID, receiverChannelID) {
    // Initialize
    var output = '';

    // Processing
    output += '<button class="btn btn-outline-primary btn-sm" onclick="sendMessageGroup(' + document.getElementById('hidden_user_id').value + ', ' + receiverGroupID + ', ' + receiverChannelID + ')">Envoyer</button>';

    return output;
}

function displayFormatedDate(date) {
    // Initialize
    var output = '';

    // Processing
    output += date.getFullYear();
    output += "-";
    output += (date.getMonth() + 1).toLocaleString('en-US', {minimumIntegerDigits: 2, useGrouping:false});
    output += "-";
    output += date.getDate().toLocaleString('en-US', {minimumIntegerDigits: 2, useGrouping:false});
    output += " "
    output += date.getHours().toLocaleString('en-US', {minimumIntegerDigits: 2, useGrouping:false});
    output += ":";
    output += date.getMinutes().toLocaleString('en-US', {minimumIntegerDigits: 2, useGrouping:false});
    output += ":";
    output += date.getSeconds().toLocaleString('en-US', {minimumIntegerDigits: 2, useGrouping:false});

    // Exit
    return output;
}