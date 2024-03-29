<?php
// Projet: M306_SRM
// Script: Modèle API getMessages.php
// Description: endpoint de récupération de la table messages.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 07.04.2021, version initial

include "../models/messages.php";

$response = [];

$channelID = filter_input(INPUT_GET, 'channelID', FILTER_VALIDATE_INT);

$response['count'] = CountAllMessagesForGroupChannel($channelID);
$response['messages'] = GetAllMessagesForGroupChannel($channelID);

header('Access-Control-Allow-Origin: *');
header('Content-Type:application/json');
echo(json_encode($response));