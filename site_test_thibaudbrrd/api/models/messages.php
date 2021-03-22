<?php
// Projet: M306_SRM
// Script: Modèle messages.php
// Description: contient les fonctions en lien avec la table messages.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 22.03.2021 / Codage initial

require_once 'models/dbConnect.php';

/**
 * récupère tous les enregistrements de la table messages associer aux utilisateurs donné
 * @param int idChannel : id du channel dont les messages doivent être récupèrer
 * @return array tableau contenant les enregistrements
 */
function getAllMessagesBetweenUserAAndUserB($idUserA, $idUserB)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name`, `u`.`profilPictureURL`, `r`.`color`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE (`m`.`senderUserID` = :idUserA AND `m`.`receiverUserID` = :idUserB)
        OR (`m`.`senderUserID` = :idUserB AND `m`.`receiverUserID` = :idUserA)
        ORDER BY `m`.`date`");
    $query->bindParam('idUserA', $idUserA, PDO::PARAM_INT, 11);
    $query->bindParam('idUserB', $idUserB, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);

    $query = transformImageURLToHtmlImgTag($query, 'Image de profile', 'Surnom');
    
    return $query;
}

/**
 * récupère tous les enregistrements de la table messages associer au channel donné
 * @param int idChannel : id du channel dont les messages doivent être récupèrer
 * @return array tableau contenant les enregistrements
 */
function getAllMessagesForGroupChannel($idChannel)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name` as 'username', `u`.`profilPictureURL`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE `m`.`receiverChannelID` = :idChannel
        ORDER BY `m`.`date`");
    $query->bindParam('idChannel', $idChannel, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query;
}
