<?php
	
	//check of de usernaam al in gebruik is
	function userExist($username){
		global $sql;
		$query=$sql->query("select * from user where username='".$username."'");
		if($sql->aantal($query)){
			return true;
		}else{
			return false;
		}		
	}
	
	//als je administrator bent of je jezelf bent.. mag je aanpassen
	if($user->userdata['administrator']||$_POST['id']==$user->userdata['id']){

		//als al bestaat genereer een update query
		if($_POST['id']){
			$qs="update user set ";
			if($user->userdata['administrator']){
				$qs.="administrator='".$_POST['administrator']."', ";
			}
			if($_POST['password']){
				$qs.="password = '".md5($_POST['password'])."', ";
			}
			
			$qs.="fullName='".$_POST['fullName']."', ";
			if(!userExist($_POST['username'])&&$_POST['username']){
				$qs.="username='".$_POST['username']."', ";
				$json->add("error",0);
			}else{
				$json->add("error",1);
			}
			
			$qs.="profileText='".$_POST['profileText']."', ";
			$qs.="email='".$_POST['email']."' ";
			$qs.=" where id='".$_POST['id']."'";
			
			//voer update query uit
			$sql->query($qs);
		}else{	
		
			//als niet bestaat.. maak nieuwe user aan
			if(!userExist($_POST['username'])&&$_POST['username']){
				if($_POST['password']){
					//generereer user query
					$qs="insert into user set ";
					$qs.="administrator='".$_POST['administrator']."', ";
					$qs.="password = '".md5($_POST['password'])."', ";
					$qs.="fullName='".$_POST['fullName']."', ";
					$qs.="username='".$_POST['username']."', ";
					$qs.="profileText='".$_POST['profileText']."', ";
					$qs.="email='".$_POST['email']."', ";
					$qs.="registrationDate='".time()."' ";
					
					//voer query uit
					$sql->query($qs);
					$json->add("error",0);
				}else{
					$json->add("error","2");
				}
			}else{
				$json->add("error",1);
			}
		}
	}else{
		$json->add("error",3);
	}
?>