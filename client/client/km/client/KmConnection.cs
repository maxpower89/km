using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using km.externalCode;
using Newtonsoft.Json;


//deze class dient als verbindingshulpmiddel voor alle classes die de service gebruiken


namespace km.client
{
    class KmConnection
    {
        string host; //hostname
        bool loggedin; //of er inglogd is
        string username; //username
        string userhash; //userhash

        //constructen
        public KmConnection(string host){
            this.host=host;
            
        }

        //host ophalen
        public string getHost()
        {
            return this.host;
        }


        //authoriseren
        public bool auth(string username,string password)
        {   
            //post submitter ophalen 
            PostSubmitter submitter = new PostSubmitter(this.host);
            //variabelen toesturen
            submitter.PostItems.Add("username", username);
            submitter.PostItems.Add("password", password);
            submitter.PostItems.Add("script", "login");
            //en request done
            submitter.Type = PostSubmitter.PostTypeEnum.Post;
            //resultaat converteren naar een dictionary
            Dictionary<String, String> userdata = JsonConvert.DeserializeObject<Dictionary<String, String>>(submitter.Post());

            //als het is geslaagd
            if (userdata["succes"] == "1")
            {
                //basis informatie voor volgende requests opslaan
                this.userhash = userdata["hash"];
                this.username = username;
                this.loggedin = true;
              
                return true;
            }
            else
            {
                //anders aangeven dat het mislukt is
                this.loggedin = false;
                return false;
            }
          

           
        }
        
        //script inladen
        public String loadScript(String script, String json){
            //post submitter aanmaken
            PostSubmitter submitter = new PostSubmitter(this.host);
            //auth data opsturen
            submitter.PostItems.Add("Uhash", this.userhash);
            submitter.PostItems.Add("Uname", this.username);

            //scriptnaam opsturen
            submitter.PostItems.Add("script",script);
            //informatie in vorm van json opsturen
            submitter.PostItems.Add("json",json);
            submitter.Type = PostSubmitter.PostTypeEnum.Post;
            
            //en request uitvoeren
            return submitter.Post();
        }


        //dictionary op verschillende manieren
        public Dictionary<string, string> loadDictionary(string script, string json)
        {   
            //data ophalen van load script
            string data = this.loadScript(script, json);
            //converteren naar dictionary
            return   JsonConvert.DeserializeObject<Dictionary<String, String>>(data);
        }

        public Dictionary<string, string> loadDictionary(string script)
        {
            string data = this.loadScript(script, "{}");

            return JsonConvert.DeserializeObject<Dictionary<String, String>>(data);
        }

        public Dictionary<String,Dictionary<string,string>> loadDoubleDictionary(string script, string json){
            string data = this.loadScript(script, json);
             return JsonConvert.DeserializeObject<Dictionary<string,Dictionary<string,string>>>(data);
        }

        public Dictionary<String, Dictionary<string, string>> loadDoubleDictionary(string script)
        {
            return this.loadDoubleDictionary(script, "");
        }


        public Dictionary<string, string> convertJson(string json)
        {
            return JsonConvert.DeserializeObject<Dictionary<String, String>>(json);
        }
           

        //bestand downloaden vanuit de host
        public void download(int id,string destination)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(this.host + "openFile.php?id="+id, destination);
        }
      



    }
}
