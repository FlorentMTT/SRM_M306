<?php
// Projet: M306_SRM
// Script: Modèle channels.php
// Description: contient les fonctions en lien avec la table channels.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 01.03.2021, version initial

require_once 'models/dbConnect.php';

/**
 * récupère tous les enregistrements de la table channels qui correspondent au group donné
 * @param int $groupID : id du groupe dont les channels doivent être récupèrer
 * @return array tableau contenant les enregistrements
 */
function GetAllChannelsForGroup($groupID)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `c`.`id`, `c`.`name`
        FROM `channels` as c
        WHERE `c`.`groupID` = :groupID
        ORDER BY `c`.`place`");
    $query->bindParam('groupID', $groupID, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    return $query;
}