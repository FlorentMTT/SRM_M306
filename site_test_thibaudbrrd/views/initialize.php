<?php
// Projet: M306_SRM
// Script: Vue initialize.php
// Description: Crée la session
// Auteur: Briard Thibaud
// Version 1.0.0 PC 08.03.2021

session_start();

if (!isset($_SESSION['info_client']))
{
    // First logon
    $_SESSION['info_client'] = [
        'date_last_action' => date("Y-m-d H:i:s")
    ];
}