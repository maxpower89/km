<?php

	//user list ophalen
	

	if($_POST['search']){
		//als er gezocht moet worden
		include_once("includes/zoeken.class.php");
		$zoeken=new zoeken;
		//veld waarden bepalen
		$fields['username']=13;
		$fields['fullName']=9;
		$fields['email']=4;
		$fields['profileText']=1;
		//en zoeken maar
		$zoeken->zoek("select * from user where [where]",$_POST['search'],$fields);
		//in json array zetten
		if($zoeken->aantal){
			while($result=$zoeken->fetch()){
				$json->add($result['id'],$result);
			}
		}else{
			$json->add("succes","0");
		}
	}else{
		//als er niet hoeft worden gezocht, gewoon query uitvoeren en in json handler plaatsen
		$query=$sql->query("select * from user");
		if($sql->aantal($query)){
			while($result=$sql->fetch($query)){
				$json->add($result['id'],$result);
			}
		}else{
			$json->add("succes","0");
		}
	}

?>