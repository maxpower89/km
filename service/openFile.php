<?php
	//dit bestand is om bestanden te downloaden van de server
	foreach($_GET as $key=>$val){
		$_POST[$key]=$val;
	}
	
	
	//global inlezen
	include("includes/global.php");
	
	//bestand info  ophalen
	$result=$sql->result("select * from documents where id='".$_POST['id']."'");
	$fileUrl="data/".$result['location'];
	$fileData=file_get_contents($fileUrl);
	$fileName=$result['file'];


	//download forceren
	header('Content-Description: File Transfer');
    header('Content-Type: application/octet-stream');
    header('Content-Disposition: attachment; filename='.$fileName);
    header('Content-Transfer-Encoding: binary');
    header('Expires: 0');
    header('Cache-Control: must-revalidate');
    header('Pragma: public');
    header('Content-Length: ' . filesize($fileUrl));
	
	//output cleanen
    ob_clean();
    //headers opsturen
	flush();
	//bestand sturen.
    echo $fileData;

	
	
	
	
?>