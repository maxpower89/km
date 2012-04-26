<?php
//document verwijderen
	if($_POST['id']){
		//als er een id is opgestuurd. verwijderen
		$result=$sql->result("select * from documents where id='".$_POST['id']."'");
		unlink("data/".$result['location']);
		$sql->query("delete from documents where id='".$_POST['id']."'");
		$json->add("success",1);
	}else{
		//anders terug sturen dat het is mislukt
		$json->add("success",0);
	}
?>