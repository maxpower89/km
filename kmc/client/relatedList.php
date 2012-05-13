<?php
	class RelatedList extends DataObject{
		
		var $list;
		
		function __construct($con,$tags,$id){
			$this->DataObject($con);

			$dataA=$this->con->loadArray("loadRelatedList",'{"tags":"'.$tags.'","id":"'.$id.'"}');
			foreach($dataA as $key=>$val){
				$this->list[]=new document($con,$val);				
			}
		}
		
	}
?>