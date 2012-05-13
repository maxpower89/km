<?php
	class Document extends DataObject{
		var $id;
        var $user;
        var $title;
        var $file;
        var $description;
        var $tags;
        var $fileData;
        private $related;
		
		
		function __construct($con,$data=NULL){
			$this->DataObject($con);
			if($data){
				if(!is_array($data)){
					$data=$this->con->loadArray("loadDocumentinfo", "{\"id\":\"" . $data . "\"}");
				}
			   $this->id=$data['id'];
			   $this->file = $data["file"];
               $this->user = $data["user"];
               $this->title = $data["title"];
               $this->description = $data["description"];
               $this->tags = $data["tags"];	
			}
		}
		
		function save($file=""){
			if($file){
				$this->fileData=base64_encode(file_get_contents($file));
			}
			$json= json_encode($this);
			return $this->con->loadScript("saveDocument",$json);
		}
		
		function delete(){
			return $this->con->loadDictionary("deleteDocument", "{\"id\":\"" . $this->id . "\"}");
		}
		
		function interested(){
			$this->con->loadDictionary("saveInterest","{\"tags\":\"".$this->tags."\"}");
		}
		
		function getRelated(){
			if ($this->related)
            {
                return $this->related;
            }
            else
            {
                $this->related = new RelatedList($this->con, $this->tags,$this->id);
                return $this->related;
            }
		}
		

		
		
		
		
	}
?>