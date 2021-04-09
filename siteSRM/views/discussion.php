<?php
// Projet: M306_SRM
// Script: Vue exemple.php
// Description: Page d'exemple
// Auteur: Briard Thibaud
// Version 1.1.0 PC 17.03.2021, version initial

$pageTitle = "Discussion";

include "initialize.php";

include "header.php";

?>
<div id="discussion-page" class="card col-sm-12 border-0">
    <div class="row">
        <ul id="list-groups" class="list-group col-sm-2"></ul>
        <ul id="list-channels" class="list-group col-sm-2"></ul>
        <div class="card col-sm-8">
            <div class="container card-body">
                <ul id="list-messages" class="list-group" style="height:700px; overflow-y: scroll;"></ul>
                <div class="row">
                    <div class="cols-sm-10">
                        <form id="form-send-message">
                            <div class="input-group">
                                <input type="text" id="content" name="content" class="form-control"></input>
                            </div>
                        </form>
                    </div>
                    <div id="message-sender" class="col-sm-2"></div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type='text/javascript' > 
    var listGroups = [];
    var activeGroup = 0;
    var activeChannel = 0;
    var nbMessages = 0;
    var messageGetter
</script>
<script src="js/getData.js"></script>
<script src="js/showData.js"></script>
<script src="js/displaytoolbox.js"></script>

<?php include "footer.php" ?>