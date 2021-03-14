<?php
// Projet: M306_SRM
// Script: Modèle users.php
// Description: contient les fonctions en lien avec la table users.
// Auteur: Thibaud Briard
// Version 1.0.0 PC 01.03.2021 / Codage initial

require_once 'models/dbConnect.php';

/**
 * récupère tous les enregistrements de la table users
 * @return array tableau contenant les enregistrements
 */
function getAllUsers()
{
    $connexion = connectDB();
    $requete = $connexion->prepare(
        "SELECT `u`.`id`, `u`.`name`, `u`.`profilPictureURL`
        FROM `users` as u
        ORDER BY `u`.`id`");
    $requete->execute();
    $requete = $requete->fetchAll(PDO::FETCH_ASSOC);

    $requete = transformImageURLToHtmlImgTag($requete, 'Image de profile', 'Surnom');
    
    return $requete;
}

/**
 * récupère un enregistrement de la table users grâce à son ID
 * @param string email de l'user à retourner
 * @return array tableau contenant les informations du user
 */
function getUserByID($userID)
{
    $connexion = connectDB();
    $requete = $connexion->prepare(
        "SELECT `u`.`id`, `u`.`name`, `u`.`profilPictureURL`
        FROM `users` as u
        WHERE `u`.`id` = :userID");
    $requete->bindParam('userID', $userID, PDO::PARAM_INT, 11);
    $requete->execute();
    $requete = $requete->fetchAll(PDO::FETCH_ASSOC);

    $requete = transformImageURLToHtmlImgTag($requete, 'Image de profile', 'Surnom');
    
    return $requete;
}

function getAllUsersWithRoles()
{
    $connexion = connectDB();
    $requete = $connexion->prepare(
        "SELECT `u`.`id`, `u`.`name`, `u`.`profilPictureURL`, group_concat(`r`.`name` separator ', ') as 'role(s)'
        FROM `users` as u
        LEFT JOIN `relationsrolesusers` as `rru` on `u`.`id` = `rru`.`userID`
        LEFT JOIN `roles` as `r` on `rru`.`roleID` = `r`.`id`
        GROUP BY `u`.`id`
        ORDER BY `u`.`id`");
    $requete->execute();
    return $requete->fetchAll(PDO::FETCH_ASSOC);
}

function getUserByIDWithRoles($userID)
{
    $connexion = connectDB();
    $requete = $connexion->prepare(
        "SELECT `u`.`id`, `u`.`name`, `u`.`profilPictureURL`, group_concat(`r`.`name` separator ', ') as 'role(s)'
        FROM `users` as u
        LEFT JOIN `relationsrolesusers` as `rru` on `u`.`id` = `rru`.`userID`
        LEFT JOIN `roles` as `r` on `rru`.`roleID` = `r`.`id`
        WHERE `u`.`id` = :userID
        GROUP BY `u`.`id`");
    $requete->bindParam('userID', $userID, PDO::PARAM_INT, 11);
    $requete->execute();
    return $requete->fetchAll(PDO::FETCH_ASSOC);
}

function checkUserByEmailPassword($email, $password)
{
    $connexion = connectDB();
    $requete = $connexion->prepare(
        "SELECT `u`.`id`
        FROM `users` as u
        WHERE `u`.`email` = :email
        AND `u`.`password` = :password");
    $requete->bindParam('email', $email, PDO::PARAM_STR, 100);
    $requete->bindParam('password', $password, PDO::PARAM_STR, 64);
    $requete->execute();
    $requete = $requete->fetchAll(PDO::FETCH_ASSOC);

    if (!empty($requete[0])) {
        return [true, $requete[0]['id']];
    }
    return [true, null];
}