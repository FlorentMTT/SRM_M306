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
        "SELECT `g`.`id`, `g`.`name`, `g`.`profilPictureURL`, GROUP_CONCAT(CONCAT(`c`.`id`, ':', `c`.`name`, ':', `c`.`place`) ORDER BY c.place ASC SEPARATOR ' | ') AS 'channels'
        FROM `groups` AS g
        LEFT JOIN `channels` AS c ON `g`.`id` = `c`.`groupID`
        LEFT JOIN `relationsgroupsusers` AS rgu ON `g`.`id` = `rgu`.`groupID`
        WHERE `g`.`active` = 1
        AND `rgu`.`userID` = :userID
        GROUP BY `g`.`id`");
    $query->bindParam('userID', $userID, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    return $query;
}