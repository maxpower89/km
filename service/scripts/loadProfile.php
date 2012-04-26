<?php
	//profiel inladen
	//als id -1 is dan eigen userdata ophalen
	if($_POST['id']==-1){
		$_POST['id']=$user->userdata['id'];
	}
	
	//resultaat ophalen
	$result=$sql->result("select * from user where id='".$_POST['id']."'");
	
	
	//en in json array zetten
	if(is_array($result)){
		//basis informatie ophalen
		foreach($result as $key=>$val){
			$json->add($key,$val);
		}
		
		//datums omzetten in menselijk leesbaar formaat
		$json->add("lastLoginDate",date("d-m-Y H:i:s",$result['lastLoginDate']));
		$json->add("registrationDate",date("d-m-Y H:i:s",$result['registrationDate']));
		
		

		
		
		$json->add("succes","1");
	}else{
		$json->add("succes","0");
	}
	
?>