<?php
//confituratie zetten
	$config['sql']['host']="http://korhelf59.fiftynine.axc.nl/stenden/kennismanagement/service/";
	$config['sql']['user']="korhelf59_mi4f";
	$config['sql']['pass']="Kz70dJIh";
	$config['sql']['name']="korhelf59_mi4f";
	
	$config['noLogin']['login']=true;
	
	//belangrijke classes inladen
	include("includes/sql.class.php");
	include("includes/user.class.php");
	include("includes/json.class.php");
	
?>