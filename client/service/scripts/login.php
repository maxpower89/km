<?php

	$hash=$user->login($_POST['username'],$_POST['password']);
	$json->add("hash",$hash);
	if($logindata['hash']){
		$json->add("succes","1");
	}else{
		$json->add("succes","0");
	}

?>