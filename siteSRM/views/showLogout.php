<?php
// Projet: MMPLOApp
// Script: Vue logout.php
// Description: Page de déconnexion du site
// Auteur: Briard Thibaud
// Version 1.0.0 PC 21.12.2020 / Codage initial

$pageTitle = "Log out";

include "initialize.php";

$errorMsg = "";
if (filter_has_var(INPUT_GET,'submit')) {

    $_SESSION['info_client']['user'] = null;
    $errorMsg = "Vous avez bien été déconnecté";
}

include "header.php";
?>

<form action="index.php" method="POST" class="form-horizontal">
    <?php if ($errorMsg != "") { ?>
    <div class="alert success">
        <span class="closebtn" onclick="this.parentElement.style.display='none';">&times;</span>
        <?= $errorMsg ?>
    </div>
    <?php } ?>
    <div class="form-group">
        <div class="col-sm-6">
        </div>
        <div class="col-sm-12">
            <input type="submit" name="submit" value="Retour à l'Acceuil"/>
        </div>
    </div>
</form>

<?php include "footer.php" ?>