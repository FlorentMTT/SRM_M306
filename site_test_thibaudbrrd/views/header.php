<?php
// Projet: M306_SRM
// Script: Vue header.php
// Description: entête HTML des pages du site 
// Auteur: Favre Steven
// Version 1.0.0 PC 22.02.2021, version initial


if (empty($pageTitle)){
    $pageTitle = "sans titre";
}

?>
<!DOCTYPE html>
<html>    
    <head>
        <title>M306_SRM - <?= $pageTitle ?></title>
        <meta charset="utf-8" />
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="css/style.css">
        
    </head>
    <body>
        <div class="container">
            <header>
                <h1 class="card-title">M306_SRM</h1>
            </header>

            <?php include_once 'views/menu.php'; ?>

            <div class="row">
                <div class="col-sm-10">
                    <h4><?= $pageTitle ?></h4>
                </div>
            </div>
