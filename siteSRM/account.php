<?php
// Projet: M306_SRM
// Script: Page account.php
// Description: Page de gestion de compte
// Auteur: Favre Steven

$pageTitle = "Mon compte";
include 'views/header.php';

?>

<div class="card col-sm-12 border-0">
    <div class="row">
        <div class="card col-sm-12" style="height:400px; overflow-y: scroll;">
            <form action="login.php" method="POST" class="form-horizontal">
            <br>
                <?php include_once 'views/account.php' ?>
            </form>
        </div>
    </div>
</div>

<?php include 'views/footer.php'; ?>