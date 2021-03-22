<?php
// Projet: M306
// Script: Vue menu.php
// Description: menu dynamique du site
// Auteur: Meyer Florent
// Version 1.0.0 PC 22.02.2021, version initial

?>
<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="#">Nav</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul id="navbarSupportedContent" class="navbar-nav mr-auto">
      <li class="nav-item">
        <a class="nav-link" href="./">Home</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="./exemple.php" role="button" >Exemple</a>
      </li>
    </ul>
    <ul class="navbar-nav ml-auto">
      <?php if (isset($_SESSION['info_client']['user'])) { ?>
        <li class="nav-item">
          <a class="nav-link" href="./account.php">My account</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="./logout.php?submit=deconnexion">Log out</a>
        </li>
      <?php } else { ?>
        <li class="nav-item">
          <a class="nav-link" href="./login.php">Log in</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="./signin.php">Sign in</a>
        </li>
      <?php } ?>
    </ul>
  </div>
</nav>