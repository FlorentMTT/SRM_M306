<?php
// Projet: M306_SRM
// Script: Modèle API getChannels.php
// Description: endpoint de récupération de la table channels.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 22.03.2021, version initial
include "models/channels.php";

include "views/displayToolbox.php";

$groupID = filter_input(INPUT_GET, "groupID", FILTER_VALIDATE_INT);

echo(getGroups($groupID));

function getGroups($groupID) {
    // Initialize
    $output = '';

    // Processing
    $data = GetAllChannelsForGroup($groupID);
    $output .= displayListChannels($data);

    // Exit
    return $output;
}