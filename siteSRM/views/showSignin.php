<?php
// Projet: M306_SRM
// Script: Vue login.php
// Description: Page de connexion du site
// Auteur: Favre Steven
// Version 1.0.0 PC 08.03.2021 / Codage initial

$pageTitle = "Sign in";

include "initialize.php";
include "models/users.php";

$errorMsg = "";
$email = "";
$name = "";
if (filter_has_var(INPUT_POST,'submit')) {

    // récupération des données provenant de la saisie par l'utilisateur
    $email = filter_input(INPUT_POST,'email', FILTER_SANITIZE_STRING);
    $password = filter_input(INPUT_POST,'password', FILTER_SANITIZE_STRING);
    $name = filter_input(INPUT_POST,'name', FILTER_SANITIZE_STRING);

    $response = createUser($email, hash("sha256", "$password"), $name);
    $_SESSION['info_client']['date_last_action'] = date("Y-m-d H:i:s");
    if (true) {
        header("location:login.php");
        exit;
    }
    else {
        $errorMsg = "vous avez une erreur de saisie";
    }
}

include "header.php";
?>

<form action="signin.php" method="POST" class="form-horizontal">
    <?php if ($errorMsg != "") { ?>
    <div class="alert error">
        <span class="closebtn" onclick="this.parentElement.style.display='none';">&times;</span>
        <?= $errorMsg ?>
    </div>
    <?php } ?>
    <div class="form-group">
        <label class="control-label col-sm-3" for="email">Email : </label>
        <div class="col-sm-9">
            <input class="form-control" type="email" name="email" id="email" value="<?= $email ?>">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-3" for="password">Password : </label>
        <div class="col-sm-9">
            <input class="form-control" type="password" name="password" id="password" value="">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-3" for="name">Name : </label>
        <div class="col-sm-9">
            <input class="form-control" type="text" name="name" id="name" value="<?= $name ?>">
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-6">
        </div>
        <div class="col-sm-12">
            <input type="submit" name="submit" value="Se connecter"/>
        </div>
    </div>
</form>

<?php include "footer.php" ?>