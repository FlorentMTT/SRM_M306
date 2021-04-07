<?php 

require_once '../models/users.php';

$dataUser = getUserByID($_SESSION['info_client']['user']);
var_dump($dataUser);

echo '<div class="form-group">';
echo '<label class="control-label col-sm-3" for="name">Name : </label>';
echo '<input class="form-control" type="text" name="name" id="name" value="' . $dataUser['name'] . '">';
echo '</div>';