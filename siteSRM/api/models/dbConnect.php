<?php
// Projet: M306_SRM
// Script: dbConnect.php
// Description: ce script permet la connexion a la DB
// Auteur: Briard Thibaud
// Version 1.0.0 PC 01.03.2021, version initial /!\ NON SÉCURISÉ /!\ (mot de passe : vide)

define("DB_NAME", "m306_srm_db");
define("DB_USER", "root");
define("DB_PASSWORD", "root");

function connectDB()
{
    static $myDb = null;
    if ($myDb === null) {
        try {
            $myDb = new PDO(
                "mysql:host=localhost;dbname=" . DB_NAME . ";charset=utf8",
                DB_USER,
                DB_PASSWORD,
                array(PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
                PDO::ATTR_EMULATE_PREPARES => false)
            );
        }
        catch (Exception $e) {
            die("Impossible de se connecter à la base ". $e->getMessage());    
        }
    }
    return $myDb;
}