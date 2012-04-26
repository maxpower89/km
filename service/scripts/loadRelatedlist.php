<?php
		//tags veranderen in zoek class zoekstring
		$zoekstring=str_replace(","," ",$_POST['tags']);
		
		//overbodige whitespace verwijderen
		while($oldZoekstring!=$zoekstring){
			$oldZoekstring=$zoekstring;
			$zoekstring=str_replace("  "," ",$zoekstring);
		}
		
	
		//zoeken class inladen
		include_once("includes/zoeken.class.php");
		$zoeken=new zoeken;
		
		//veld rates bepalen
		$fields['title']=13;
		$fields['tags']=6;
		$fields['description']="1";
		$fields['file']=2;
		
		//en zoeken
		$zoeken->zoek("select * from documents where id!='".$_POST['id']."' and ([where])",$zoekstring,$fields);

		
		//zoeken in json handler zetten
		if($zoeken->aantal){
			$i=0;
			while($result=$zoeken->fetch() and $i<10){
				$json->add($result['id'],$result);
				$i++;
			}
		}else{
			$json->add("succes","0");
		}

	

?>