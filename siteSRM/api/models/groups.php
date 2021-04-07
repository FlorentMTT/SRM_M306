<?php
// Projet: M306_SRM
// Script: Modèle groups.php
// Description: contient les fonctions en lien avec la table Groups.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 01.03.2021, version initial

require_once 'models/dbConnect.php';

/**
 * récupère tous les enregistrements de la table roles
 * @return array tableau contenant les enregistrements
 */
function GetAllGroupsForUser($userID)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `g`.`id`, `g`.`name`, `g`.`profilPictureURL`
        FROM `groups` as g
        LEFT JOIN `relationsgroupsusers` as rgu ON `g`.`id` = `rgu`.`groupID`
        WHERE `g`.`active` = 1
        AND `rgu`.`userID` = :userID");
    $query->bindParam('userID', $userID, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    return $query;
}