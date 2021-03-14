<?php
// Projet: M306_SRM
// Script: Vue login.php
// Description: Page de connexion du site
// Auteur: Briard Thibaud
// Version 1.0.0 PC 08.03.2021 / Codage initial

$pageTitle = "Log in";

include "initialize.php";
include "models/users.php";

$errorMsg = "";
$email = "";
if (filter_has_var(INPUT_POST,'submit')) {

    // récupération des données provenant des données saisies par l'utilisateur
    $email = filter_input(INPUT_POST,'email', FILTER_SANITIZE_STRING);
    $password = filter_input(INPUT_POST,'password', FILTER_SANITIZE_STRING);

    $response = checkUserByEmailPassword($email, hash("sha256", "$password"));
    var_dump($response);
    if ($response[0]) {
        $_SESSION['info_client']['user'] = $response[1];
        header("location:index.php");
        exit;
    }
    else {
        $errorMsg = "vous avez une erreur de saisie";
    }
}

// $form = formHeader("login.php", "POST", "form-horizontal");
// if ($errorMsg != "") {
//    $form .= "<div class=\"alert error\">";
//    $form .= "<span class=\"closebtn\" onclick=\"this.parentElement.style.display='none';\">&times;</span>";
//    $form .= $errorMsg;
//    $form .= "</div>";
//}
//$form .= formInput("email", "Email", $email, "email");
//$form .= formInput("password", "Password", "", "password");
//$form .= formFooter("Se connecter");

include "header.php";
?>

<!-- <?= $form ?> -->

<?php include "footer.php" ?>