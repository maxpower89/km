<?php
	//login script.. 
	
	//proberen in te loggen met user class
	$hash=$user->login($_POST['username'],$_POST['password']);
	$json->add("hash",$hash);
	if($hash){
		$json->add("succes","1");
	}else{
		$json->add("succes","0");
	}

?>