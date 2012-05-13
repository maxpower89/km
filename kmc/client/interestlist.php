<?php
	class InterestList extends DataObject{
		
		var $list;
		
		function __construct($con){
			$this->DataObject($con);

			$dataA=$this->con->loadArray("loadInterestList");
			foreach($dataA as $key=>$val){
				$this->list[]=new document($con,$val);				
			}
		}
		
	}
?>