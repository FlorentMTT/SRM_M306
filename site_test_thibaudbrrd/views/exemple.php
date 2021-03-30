<?php
// Projet: M306_SRM
// Script: Vue exemple.php
// Description: Page d'exemple
// Auteur: Briard Thibaud
// Version 1.0.0 PC 22.02.2021, version initial
// Version 1.1.0 PC 17.03.2021, version initial

$pageTitle = "Discussion";

include "initialize.php";

include "header.php";

?>
<div class="card col-sm-12 border-0">
    <div class="row">
        <ul id="list-groups" class="list-group col-sm-2"></ul>
        <ul id="list-channels" class="list-group col-sm-2"></ul>
        <div class="card col-sm-8" style="height:700px; overflow-y: scroll;">
            <div id="list-messages" class="container card-body"></div>
        </div>
        <div class="card col-sm-12 border-0 ">
            <div class="input-group d-flex justify-content-end">
                <input id="message"></input>
                <div class="input-group-append">
                    <button class="btn btn-outline-primary btn-sm" onclick()>Envoyer</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script src="js/getData.js">
    <?php include "footer.php" ?>