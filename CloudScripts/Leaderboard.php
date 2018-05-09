<?php

include "db.php";

$sql = "SELECT * FROM GalaxyOdyssey_PlayerData ORDER by highscore";
$data = $db->query($sql);

foreach ($data as $value)
{
    echo $value["nickname"].",";
    echo $value["highscore"]."|";
}


?>