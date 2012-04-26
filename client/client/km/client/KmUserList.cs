using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace km.client
{
    class KmUserList:KmDataobject
    {
        //basis variabelen..
        private string jsonString;
        public List<KmUser> list;

        //enkele constructors.. wil je zoeken etc..
        public KmUserList(KmConnection con) : base(con) 
        { 
           list= new List<KmUser>();
           load(); 
        }
        public KmUserList(KmConnection con, string search)
            : base(con)
        {
            list=new List<KmUser>();
            load(search);   
        }


        //laden met zoekstring
        public void load(string search)
        {
            //json code definieren
            this.jsonString = "{\"search\":\""+search+"\"}";
            doLoad();
        }

        //laden zonder zoekstring
        public override void load()
        {
            this.jsonString = "";
            doLoad();
        }

        //werkelijke inladen
        private void doLoad()
        {
            //inladen via internet
            Dictionary<string, Dictionary<string, string>> data = con.loadDoubleDictionary("loadUserList", jsonString);

            //users ophalen
            foreach (KeyValuePair<string, Dictionary<string, string>> user in data)
            {   
                //user objecten aanmaken
                KmUser userObject = new KmUser(con, user.Value);
                this.list.Add(userObject);
            }

        }


    }
}
