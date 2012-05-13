<?php
	include("client/global.php");
	$connection=new Connection("http://localhost/km/");
	$connection->auth("mark","wachtpas");
	
	$document = new Document($connection,5);
	print_r($document->getRelated());

	
?>