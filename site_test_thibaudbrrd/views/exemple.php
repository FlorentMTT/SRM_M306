<?php
// Projet: M306_SRM
// Script: Vue exemple.php
// Description: Page d'exemple
// Auteur: Nom Prenom
// Version 1.0.0 PC 22.02.2021, version initial

$pageTitle = "Page Name";

include "initialize.php";

include "header.php";

?>
<div class="card col-sm-12">
    <div class="row">
        <ul id="list-groups" class="list-group col-sm-2"></ul>
        <div class="card col-sm-10">
            <div class="container card-body">
            </div>
        </div>
    </div>
</div>

<script src="js/getGroups.js">
<script src="js/getMessages.js">

<?php include "footer.php" ?>