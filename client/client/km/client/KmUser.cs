using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace km.client
{
    class KmUser:KmDataobject
    {
        //user variabelen..
        public  int id;
        public string username;
        public string password;
        public string fullName;
        public string email;
        public string lastLoginDate;
        public string registrationDate;
        public string profileText;
        public bool administrator;

        public int commonInterest=-1;

 
        //enkele constructors.. hoe wil je de user ophalen.
        public KmUser(KmConnection con):base(con){}
        public KmUser(KmConnection con, int id) : base(con) {
            this.id = id;
            load();
        }
        public KmUser(KmConnection con, Dictionary<string, string> data):base(con){
            this.id=int.Parse(data["id"]);
            this.load(data);
        }

        //laden met bestaande dictionary
        public void load(Dictionary<string, string> data)
        {
            
            //gegevens in variabelen zetten
            this.username = data["username"];
            this.fullName = data["fullName"];
            this.email = data["email"];
            this.lastLoginDate = data["lastLoginDate"];
            this.registrationDate = data["registrationDate"];
            this.profileText = data["profileText"];

            if (data["administrator"] == "1")
            {
                this.administrator = true;
            }
            else
            {
                this.administrator = false;
            }

        }


        //gegevens laden via internet
        public override void load()
        {
            //request uitvoeren
            Dictionary<string, string> data = con.loadDictionary("loadProfile", "{\"id\":\"" + this.id + "\"}");

            //en gegevens in variabelen zetten
            this.id = int.Parse(data["id"]);
            this.username = data["username"];
            this.fullName = data["fullName"];
            this.email = data["email"];
            this.lastLoginDate = data["registrationDate"];
            this.profileText = data["profileText"];

            if (data["administrator"] == "1")
            {
                this.administrator = true;
            }
            else
            {
                this.administrator = false;
            }
        }


        //gemeenschappelijke interesses ophalen
        public int getCommonInterest()
        {   
            //als er geen intest rate is geladen 
            if (this.commonInterest<0)
            {
                //laad interest rate met request
                Dictionary<string, string> data = con.loadDictionary("loadCommonInterest", "{\"id\":\"" + this.id + "\"}");
                this.commonInterest = int.Parse(data["commonInterest"]);
            }

            //return deze rate.
            return this.commonInterest;
        }

        //username in tostring. om goed te weergeven in listbox
        public override string ToString()
        {
            return this.username;
        }

        //saven van info
        public Dictionary<string,string> save()
        {
            string json = JsonConvert.SerializeObject(this);
            return con.loadDictionary("saveUser", json);
        }

        //deleten van user
        public void delete()
        {
            con.loadDictionary("deleteUser", "{\"id\":\"" + this.id + "\"}");
        }
    }
}
