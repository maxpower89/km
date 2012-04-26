using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace km.client
{
    class KmRelatedList:KmDataobject
    {

        //velden..
        string tags;
        int id;
        public List<KmDocument> list;


        //constructen
        public KmRelatedList(KmConnection con, string tags,int id):base(con)
        {
            this.list=new List<KmDocument>();
            this.tags = tags;
            this.id = id;
            this.load();
        }

        public override void load()
        {   
            //via internet lijst met gerelateerde artikelen ophalen
            Dictionary<string, Dictionary<string, string>> data = con.loadDoubleDictionary("loadRelatedlist", "{\"tags\":\"" + this.tags + "\",\"id\":\"" + this.id + "\"}");
           
            //documenten in objecten plaatsen
            foreach (KeyValuePair<string, Dictionary<string, string>> document in data)
            {
                KmDocument documentObject = new KmDocument(con, document.Value);
                this.list.Add(documentObject);
            }
        }
    }
}
