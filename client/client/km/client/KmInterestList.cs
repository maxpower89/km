using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace km.client
{
    class KmInterestList : KmDataobject
    {
        //basis variabelen
        public List<KmDocument> list;

        //constructen
        public KmInterestList(KmConnection con) : base(con) {
            list=new List<KmDocument>();
            load();
        }

        //inladen
        public override void load()
        {   
            //dictionary via internet ophalen
            Dictionary<string, Dictionary<string, string>> data = con.loadDoubleDictionary("loadInterestList");

            //documenten in lijst plaatsen
            foreach (KeyValuePair<string, Dictionary<string, string>> document in data)
            {
                KmDocument documentObject = new KmDocument(con, document.Value);
                this.list.Add(documentObject);
            }
        }
    }
}
