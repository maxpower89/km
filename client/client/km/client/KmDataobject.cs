using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//abstracte vorm van een data object
namespace km.client
{
    abstract class KmDataobject
    {
        //verbinding is verplicht
        protected KmConnection con;

        //in constructor verbinding aanmaken
        public KmDataobject(KmConnection con)
        {
            this.con = con;
        }

        //load verplicht stellen.. er moet altijd data geladen worden.
        public abstract void load();
    }
}
