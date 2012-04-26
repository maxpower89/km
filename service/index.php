<?php
	//testmode inschakelen zodat in browser kan worden gebruikt
	if($_GET['testmode']){
		foreach($_GET as $key=>$val){
			$_POST[$key]=$val;
		}
	}

	//includen van global
	include("includes/global.php");
	
	
	
	//script file bepalen
	if($_POST['script']){
		$script=$_POST['script'];
	}else{
		$script="home";
	}
	$scriptfile="scripts/".$script.".php";
	
	//script includen
	if(file_exists($scriptfile) && $user->mag()){
		include($scriptfile);
	}elseif($_GET['testmode']){
		echo "Kan bestand niet laden";	
	}
	
	
	//json op scherm zetten
	echo $json->draw();

	
?>