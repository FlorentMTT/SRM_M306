<?php
// Projet: M306_SRM
// Script: Modèle API getMessages.php
// Description: endpoint de récupération de la table messages.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 22.03.2021, version initial
include "models/messages.php";

include "views/displayToolbox.php";

$channelID = filter_input(INPUT_GET, "channelID", FILTER_VALIDATE_INT);

echo(getGroups($channelID));

function getGroups($channelID) {
    // Initialize
    $output = '';

    // Processing
    $data = getAllMessagesForGroupChannel($channelID);
    $output .= displayListMessages($data);

    // Exit
    return $output;
}