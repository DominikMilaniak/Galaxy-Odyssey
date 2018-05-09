<?php

	include "db.php";


	$sql = "SELECT * FROM GalaxyOdyssey_PlayerData";
    $data = $db->query($sql);

	foreach ($data as $value) {
      $id = $value["id"];
      $nickname = $value["nickname"];
      $highscore = $value["highscore"];

    }

    echo $id." ".$nickname." ".$highscore;

?>