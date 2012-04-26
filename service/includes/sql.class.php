<?

	class sql{
		var $connection;
		var $connectioninfo;
		var $queries;
	
		//construct
		function sql(){
			global $config;
			$this->connectioninfo=$config['sql'];
			$this->connect();			
		}
	
		//verbinding maken
		function connect(){
			$this->connection=@mysql_connect($this->connectioninfo['host'],$this->connectioninfo['user'],$this->connectioninfo['pass'])  or print(@mysql_error($this->connection));
			@mysql_select_db($this->connectioninfo['name'],$this->connection)  or print(@mysql_error($this->connection));
			
		}
	
		//query
		function query($string){
			$string=str_replace("[prefix]",$_COOKIE['klant']."_",$string);
			$query=@mysql_query($string,$this->connection) or print(@mysql_error($this->connection));
			$this->queries++;
			return $query;
		}
			
		//fetchen
		function fetch($query){
			$fetch=@mysql_fetch_assoc($query) ;
			return $fetch;
		}
		
		//als object fetchen
		function fetch_object($query){
			$fetch=@mysql_fetch_object($query) ;
			return $fetch;
		}
	
		//resultaat van query rechtstreeks
		function result($query){
			$fetch=$this->fetch($this->query($query));
			return $fetch;
		}
	
		//aantal resultaten van query
		function aantal($query){
			$aant=@mysql_num_rows($query);
			return $aant;
		}
		
	

			//naar rij verspringen
		function goRow($query,$row){
			return @mysql_data_seek($query,$row,$this->connection);
		}
		
	}
	$sql=new sql;
	
	

?>
