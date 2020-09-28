using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSite.Backend
{
    public class Page2
    {
        private String color { get; set; }
        private String label { get; set; }
        private String description { get; set; }

        public Page2()
        {
            color = "blueviolet";
            description = "information";
            label = "Page_2";
        }

        public String GetColor()
        {
            return color;
        }

        public String GetDescription()
        {
            return description;
        }

        public String GetLabel()
        {
            return label;
        }

        public String[][] GetData()
        {
            String[][] data = {
               new String[] { "John", "Doe", "25"  },
               new String[] { "Jane", "Doe", "50"  },
               new String[] { "Jim",  "Doe", "75"  },
               new String[] { "Joy",  "Doe", "100" },
            };
            return data;
        }
    }
}
