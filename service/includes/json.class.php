<?php
	class json{
		var $data;
		//construct
		function json(){
			$this->getData();	
		}
		
		//toevoegen aan array
		function add($key,$val){
			$this->data[$key]=$val;
		}
		
		//json string op scherm zetten
		function draw(){
			return json_encode($this->data);
			
		}
		
		//json postdata converteren naar gewone post array
		function getData(){
			if($_POST['json']){
				$json=json_decode($_POST['json']);
				if(is_object($json)){
					foreach($json as $key=>$val){
						$_POST[$key]=$val;
					}
				}
		
			}
		}
		
		
		
	}
	
	$json=new json();
	
?>