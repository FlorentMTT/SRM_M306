<?php
// Projet: M306_SRM
// Script: API groups.php
// Description: page de récupération et de formatage des groups de l'utilisateur
// Auteur: Thibaud Briard
// Version 1.0.0 PC 29.03.2021, version initial

include "../models/groups.php";

$response = [];

$userID = filter_input(INPUT_GET, 'userID', FILTER_VALIDATE_INT);

$response = GetAllGroupsForUser($userID);
foreach ($response as $key => $row) {
    $row['channels'] = explode(' | ' , $row['channels']);
    foreach ($row['channels'] as $num => $channel) {
        $row['channels'][$num] = [];
        $row['channels'][$num]['id'] = explode(':' , $channel)[0];
        $row['channels'][$num]['name'] = explode(':' , $channel)[1];
        $row['channels'][$num]['place'] = explode(':' , $channel)[2];
    }
    $response[$key] = $row;
}

header('Access-Control-Allow-Origin: *');
header('Content-Type:application/json');
echo(json_encode($response));