<?php
// Projet: M306_SRM
// Script: Modèle API getMessages.php
// Description: endpoint de récupération de la table messages.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 07.04.2021, version initial

include "../models/messages.php";

$response = [];

$content = filter_input(INPUT_POST, 'content', FILTER_SANITIZE_STRING);
$senderUserID = filter_input(INPUT_POST, 'senderUserID', FILTER_VALIDATE_INT);
$receiverGroupID = filter_input(INPUT_POST, 'receiverGroupID', FILTER_VALIDATE_INT);
$receiverChannelID = filter_input(INPUT_POST, 'receiverChannelID', FILTER_VALIDATE_INT);

$response = SendMessageForGroupChannel($content, $senderUserID, $receiverGroupID, $receiverChannelID);

header('Access-Control-Allow-Origin: *');
header('Content-Type:text/html');
echo(json_encode($response));