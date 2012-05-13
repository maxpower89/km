<?php
	if($_POST['id']){
		//als hij geupdated moet worden
		$result=$sql->result("select * from documents where id='".$_POST['id']."'");

		//updaten
		$sql->query("
			update documents set
				file='".$_POST['file']."',
				title='".$_POST['title']."',
				description='".$_POST['description']."',
				tags='".$_POST['tags']."'
				where id='".$_POST['id']."'
			");
		
		
		//bestand uploaden
		if($_POST['fileData']){
			$filedata=base64_decode(urldecode($_POST['filedata']));
			$handle=fopen("data/".$result['location'],"w+");
			fwrite($handle,$filedata);
			fclose($handle);
		}
		$json->add("success",1);
	}else{
		//anders nieuw document aanmaken
		if($_POST['fileData']&&$_POST['file']){
			$location=base64_encode(time()."_".$_POST['file']."_".$user->userdata['id']);
			$sql->query("
				insert into documents set
				file='".$_POST['file']."',
				title='".$_POST['title']."',
				description='".$_POST['description']."',
				location='".$location."',
				tags='".$_POST['tags']."',
				user='".$user->userdata['id']."'
			");
			
			//en opslaan
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