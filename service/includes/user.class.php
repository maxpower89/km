<?php
	class user{
		
		var $userdata;
		//user constructor.. en check of inglogd
		function user(){
			global $sql;
			$hash=$_POST['Uhash'];
			$uname=$_POST['Uname'];
			$query=$sql->query("select * from user where hash='".$hash."' && username='".$uname."'");
			if($sql->aantal($query)){
				$this->userdata=$sql->fetch($query);
			}else{
				$this->userdata=false;
			}
		}
		
		//retuneerd of ingelogd
		function loggedin(){
			return is_array($this->userdata);
		}
		
		//kijkt of je script mag laden die je wil laden
		function mag(){
			global $config;
			if($this->loggedin()||$config['noLogin'][$_POST['script']]){
				return true;
			}else{
				return false;
			}
		}
		
		
		//doe een poging om in te loggen
		function login($username,$password){
			global $sql;
			$query=$sql->query("select * from user where password='".md5($password)."' && username='".$username."'");
			if($sql->aantal($query)){
				$userdata=$sql->fetch($query);
				$hash = $userdata['id']."_".md5(time().$username);
				$sql->query("update user set hash='".$hash."' , lastLoginDate='".time()."' where id='".$userdata['id']."'");
				return $hash;
			}
			return false;
		}
		
		
		
		
		
	}
	
	
	$user=new user();
?>