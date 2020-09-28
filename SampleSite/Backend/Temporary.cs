using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSite
{
    public class Temporary
    {

        private String name { get; set; }
        
        public Temporary()
        {
            name = "HELLO WORLD!!!";
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }
    }
}
