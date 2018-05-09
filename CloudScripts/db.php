<?php

// Connecting to database

define("dbserver", "127.0.0.1");
define("dbuser", "milando15");
define("dbpass", "FMUtw2tC");      //Heslo pro databazi ve skole FMUtw2tC
define("dbname", "milando15");






	$db = $db = new PDO(

	"mysql:host=" .dbserver. ";dbname=" .dbname,dbuser,dbpass,

	array(

		PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8",

		PDO::MYSQL_ATTR_INIT_COMMAND => "SET CHARACTER SET utf8"

)

);


?>