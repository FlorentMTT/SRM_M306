<?php
// Projet: M306_SRM
// Script: Modèle messages.php
// Description: contient les fonctions en lien avec la table messages.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 22.03.2021 / Codage initial

require_once 'models/dbConnect.php';

/**
 * récupère le nombre d'enregistrement de la table messages que l'utilisateur donné a la possibilité de lire
 * @param int idUser : id de l'utilisateur dont les messages doivent être compté
 * @return int le nombre d'enregistrements associés à l'utilisateur
 */
function CountAllMessagesForGroupChannel($idChannel)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT COUNT(*) as 'count'
        FROM `messages` as m
        WHERE `m`.`receiverChannelID` = :idChannel");
    $query->bindParam('idChannel', $idChannel, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query[0]['count'];
}

/**
 * récupère tous les enregistrements de la table messages associer aux utilisateurs donné
 * @param int idChannel : id du channel dont les messages doivent être récupèrer
 * @return array tableau contenant les enregistrements
 */
function GetAllMessagesBetweenUserAAndUserB($idUserA, $idUserB)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name`, `u`.`profilPictureURL`, `r`.`color`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE ((`m`.`senderUserID` = :idUserA AND `m`.`receiverUserID` = :idUserB)
        OR (`m`.`senderUserID` = :idUserB AND `m`.`receiverUserID` = :idUserA))
        AND `m`.`active` = 1
        ORDER BY `m`.`date`");
    $query->bindParam('idUserA', $idUserA, PDO::PARAM_INT, 11);
    $query->bindParam('idUserB', $idUserB, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query;
}

/**
 * récupère tous les enregistrements de la table messages associer au channel donné
 * @param int idChannel : id du channel dont les messages doivent être récupèrer
 * @return array tableau contenant les enregistrements
 */
function GetAllMessagesForGroupChannel($idChannel)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name` as 'username', `u`.`profilPictureURL`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE `m`.`receiverChannelID` = :idChannel
        AND `m`.`active` = 1
        ORDER BY `m`.`date`");
    $query->bindParam('idChannel', $idChannel, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query;
}

/**
 * récupère tous les enregistrements de la table messages associer au channel donné et après la date donnée
 * @param int idChannel : id du channel dont les messages doivent être récupèrer
 * @param string date : datetime au format string (yyyy-mm-dd hh:ii:ss)
 * @return array tableau contenant les enregistrements
 */
function GetAllMessagesForGroupChannelAfterDate($idChannel, $date)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name` as 'username', `u`.`profilPictureURL`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE `m`.`receiverChannelID` = :idChannel
        AND `m`.`date` >= :date
        AND `m`.`active` = 1
        ORDER BY `m`.`date`");
    $query->bindParam('idChannel', $idChannel, PDO::PARAM_INT, 11);
    $query->bindParam('date', $date, PDO::PARAM_STR);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query;
}

function GetAllNewMessagesForGroupChannel($idChannel, $nbMessages)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "SELECT `m`.`id`, `m`.`content`, `u`.`name` as 'username', `u`.`profilPictureURL`
        FROM `messages` as m
        LEFT JOIN `users` as u on `m`.`senderUserID` = `u`.`id`
        WHERE `m`.`receiverChannelID` = :idChannel
        AND `m`.`active` = 1
        ORDER BY `m`.`date` DESC
        LIMIT :nbMessages");
    $query->bindParam('idChannel', $idChannel, PDO::PARAM_INT, 11);
    $query->bindParam('nbMessages', $nbMessages, PDO::PARAM_INT, 11);
    $query->execute();
    $query = $query->fetchAll(PDO::FETCH_ASSOC);
    
    return $query;
}

/**
 * enregistre une nouvelle ligne dans la table messages associer au contenu donnée, à l'utilisateur envoyant donnée, au groupe recevant donnée et au channel recevant donnée
 * @param string content : contenu du message
 * @param int senderUserID : id de l'utilisateur envoyant
 * @param int idReceiverGroupID : id du groupe recevant
 * @param int idReceiverChannelID : id du channel recevant
 * @return int l'ID du nouvel enregistrement
 */
function SendMessageForGroupChannel($content, $senderUserID, $idReceiverGroupID, $idReceiverChannelID)
{
    $connect = connectDB();
    $query = $connect->prepare(
        "INSERT INTO `messages` (`content`, `senderUserID`, `receiverGroupID`, `receiverChannelID`)
        VALUES (:content, :senderUserID, :idReceiverGroupID, :idReceiverChannelID)");
    $query->bindParam('content', $content, PDO::PARAM_STR, 300);
    $query->bindParam('senderUserID', $senderUserID, PDO::PARAM_INT, 11);
    $query->bindParam('idReceiverGroupID', $idReceiverGroupID, PDO::PARAM_INT, 11);
    $query->bindParam('idReceiverChannelID', $idReceiverChannelID, PDO::PARAM_INT, 11);
    $query->execute();

    return $connect->LastInsertID();
}