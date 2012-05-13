<?php
	class DocumentList extends DataObject{
		
		var $list;
		
		function __construct($con,$user="",$search=""){
			$this->DataObject($con);
			
			$json="{";
			if($user){
				$json.='"user":"'.$user.'"';
				if($search){
					$json.=',"search":"'.$search.'"';
				}
			}else{
				if($search){
					$json.='"search":"'.$search.'"';
				}
			}
			
			$json.="}";
			
			$dataA=$this->con->loadArray("loadDocumentlist",$json);
			foreach($dataA as $key=>$val){
				$this->list[]=new document($con,$val);				
			}
		}
		
	}
?>