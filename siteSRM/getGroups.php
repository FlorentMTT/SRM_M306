<?php
// Projet: M306_SRM
// Script: Modèle API getGroups.php
// Description: endpoint de récupération de la table roles.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 11.03.2021, version initial
include "models/groups.php";

include "views/displayToolbox.php";

$userID = filter_input(INPUT_GET, "userID", FILTER_VALIDATE_INT);

echo(getGroups($userID));

function getGroups($userID) {
    // Initialize
    $output = '';

    // Processing
    $data = GetAllGroupsForUser($userID);
    $output .= displayListProfilPicture($data);

    // Exit
    return $output;
}