<?php

/tags ophalen
$tags=$_POST['tags'];

//whitespace verwijderen
while($oldTags!=$tags){
	$oldTags=$tags;
	$tags=str_replace("  "," ",$tags);
}


//splitten op komma
$exp=explode(",",$tags);

//tags doorlopen
foreach($exp as $val){
	$query=$sql->query("select * from interests where user='".$user->userdata['id']."' and tag='".$val."'");
	//score van interest verhogen als deze er al was
	if($sql->aantal($query)){
		$sql->query("update interests set score=score+1  where user='".$user->userdata['id']."' and tag='".$val."'");
	}else{
		//anders interesse toevoegen
		$sql->query("INSERT INTO `interests` (
			`id` ,
			`tag` ,
			`user` ,
			`score` 
			)
			VALUES (
			NULL , '".$val."', '".$user->userdata['id']."', '1'
			)
			
			");
	}
}


$json->add("succes","1");
?>