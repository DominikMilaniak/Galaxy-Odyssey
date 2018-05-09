<?php

include "db.php";

$nickname = $_GET['nickname'];
$score = $_GET['score'];

$db;
$sqlVlozeni = 'INSERT INTO GalaxyOdyssey_PlayerData (nickname, highscore) VALUES (:nickname, :highscore)'; // nachystani dotazu 
$sqlProvedeni = $db->prepare($sqlVlozeni); // vlozeni nachystaneho dotazu 
$stav = $sqlProvedeni->execute(array(":nickname" => $nickname, ":highscore" => $score)); //doplneni dat do dotazu 
echo $stav;


?>