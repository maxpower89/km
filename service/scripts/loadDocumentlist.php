<?php
	//kijken of er een user gespecificeerd is
	if($_POST['user']){
		$where="where user='".$_POST['user']."'";
	}else{
		$where="where id>0";
	}
	
	//user query maken
	$qstring="select * from documents ".$where;
	
	//als er gezocht moet worden
	if($_POST['search']){
		include_once("includes/zoeken.class.php");
		$zoeken=new zoeken;
		
		//velden raten
		$fields['title']=13;
		$fields['tags']=6;
		$fields['description']="1";
		$fields['file']=2;
		//en zoeken met zoek class
		$zoeken->zoek($qstring. " and [where]",$_POST['search'],$fields);
		
		//zoek resultaten in json handler zetten
		if($zoeken->aantal){
			while($result=$zoeken->fetch()){
				$json->add($result['id'],$result);
			}
		}else{
			$json->add("succes","0");
		}
	}else{
		
		//als er niet gezocht moet halen gewoon query uitvoeren en in json handler zetten
		$query=$sql->query($qstring);
		if($sql->aantal($query)){
			while($result=$sql->fetch($query)){
				$json->add($result['id'],$result);
			}
		}else{
			$json->add("succes","0");
		}
	}

?>