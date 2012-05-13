<?php
	class Connection{
		
		var $host;
		var $username;
		var $hash;
		
		function __construct($host,$username="",$hash=""){
			$this->host=$host;
			$this->username=$username;
			$this->hash=$hash;
		}
		
		function auth($username,$password){
			$submitter=new PostSubmitter($this->host);
			$submitter->add("username", $username);
			$submitter->add("password",$password);
			$submitter->add("script","login");
			$data=json_decode($submitter->submit(),true);
			
			if($data['succes']){
				$this->hash=$data['hash'];
				$this->username=$username;
			}
			
			return $data;
		}
		
		function loadScript($script,$json=""){
			$submitter=new PostSubmitter($this->host);
			$submitter->Add("Uhash", $this->hash);
            $submitter->Add("Uname", $this->username);
            $submitter->Add("script",$script);
            $submitter->Add("json",$json);
			return $submitter->submit();
		}
		
		function loadArray($script,$json=""){
			return json_decode($this->loadScript($script,$json),true);
		}
		
		
	}
?>