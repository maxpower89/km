using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Web;
namespace km.client
{
    class KmDocument : KmDataobject
    {   
        //document informatie opslaan
        public readonly int id;
        public string user;
        public string title;
        public string file;
        public string description;
        public string tags;
        public string fileData;
        private KmRelatedList related=null;

  
        //verschillende constructors..
        public KmDocument(KmConnection con) : base(con) { }
        public KmDocument(KmConnection con, int id):base(con)
        {
            this.id = id;
            this.load();
        }
        public KmDocument(KmConnection con, Dictionary<string, string> data)
            : base(con)
        {
            this.id = int.Parse(data["id"]);
            load(data);
        }


        //informatie inladen van een al bestaande dictionary
        public void load(Dictionary<string, string> data)
        {
              

               this.file = data["file"];
               this.user = data["user"];
               this.title = data["title"];
               this.description = data["description"];
               this.tags = data["tags"];
        }


        //informatie inladen op basis van een request
        public override void load()
        {
            try
            {
                //doe request
                Dictionary<string, string> data = con.loadDictionary("loadDocumentinfo", "{\"id\":\"" + this.id + "\"}");

                //sla data op
                this.file = data["file"];
                this.user = data["user"];
                this.title = data["title"];
                this.tags = data["tags"];
                this.description = data["description"];
            }
            catch (Exception e)
            {
                
            }

        }

        //zorgen dat juiste naam in listboxen enzo komt
        public override string ToString()
        {
            return this.title;
        }

        //haal gerelateerde items op
        public KmRelatedList getRelated()
        {
            if (this.related != null)
            {
                //als keer eerder is opgehaald return het gewoon
                return related;
            }
            else
            {
                //sla de gerelateerde items op in een variabele
                related = new KmRelatedList(this.con, this.tags,this.id);
                return related;
            }
        }

        //toon interesse in een onderwerp
        public void interested(){
            //sla de interesse in het onderwerp op
            con.loadDictionary("saveInterest","{\"tags\":\""+this.tags+"\"}");
        }


        //bestand inladen om te uploaden
        public void loadFile(string file){
            //laad file in
              FileStream reader = new FileStream(file, FileMode.Open);
            //zet het om in een array met bytes
              byte[] buffer =new byte[reader.Length];
              reader.Read(buffer, 0, (int)reader.Length);

            //encode it naar base64
              string encoded= Convert.ToBase64String(buffer);
            //zorg dat het niet verpest word door de url.. 
              fileData = HttpUtility.UrlEncode(encoded);
                
        }

        //bestand opslaan met bestand
        public void save(string file)
        {   //bestand uploaden
            loadFile(file);

            //en opslaan
            save();
        }

        //opslaan 
        public Dictionary<string,string> save()
        {   
            //gehele object serializen
            string json= JsonConvert.SerializeObject(this);
            //en naar de server sturen
            return con.loadDictionary("saveDocument", json);
        }

        //Document downloaden
        public void download(string destination)
        {    
            con.download(this.id,destination) ;
        }

        //documetn verwijderen
        public void delete()
        {
            con.loadDictionary("deleteDocument", "{\"id\":\"" + this.id + "\"}");
        }
    }
}
