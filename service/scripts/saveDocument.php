<?php
	//als document al bestaat
	if($_POST['id']){
		
		//documetn ophalen
		$result=$sql->result("select * from documents where id='".$_POST['id']."'");

		//document updaten
		$sql->query("
			update documents set
				file='".$_POST['file']."',
				title='".$_POST['title']."',
				description='".$_POST['description']."',
				tags='".$_POST['tags']."'
				where id='".$_POST['id']."'
			");
		
		//als er een nieuw bestand is geupload.. sla deze op
		if($_POST['fileData']){
			$filedata=base64_decode(urldecode($_POST['filedata']));
			$handle=fopen("data/".$result['location'],"w+");
			fwrite($handle,$filedata);
			fclose($handle);
		}
		$json->add("success",1);
	}else{
		if($_POST['fileData']&&$_POST['file']){
			//bepaal nieuwe bestandlocatie
			$location=base64_encode(time()."_".$_POST['file']."_".$user->userdata['id']);
			//sla basis informatie op
			$sql->query("
				insert into documents set
				file='".$_POST['file']."',
				title='".$_POST['title']."',
				description='".$_POST['description']."',
				location='".$location."',
				tags='".$_POST['tags']."'
			");
			//sla het bestand op
			$filedata=base64_decode($_POST['fileData']);
			$handle=fopen("data/".$location,"w+");
			fwrite($handle,$filedata);
			fclose($handle);
			$json->add("success",1);
		}else{
			$json->add("success",0);
		}
		
	}
?>