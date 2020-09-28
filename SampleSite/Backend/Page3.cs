using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSite.Backend
{
    public class Page3
    {
        private String color { get; set; }
        private String label { get; set; }
        private String description { get; set; }

        public Page3()
        {
            color = "royalblue";
            description = "something 1";
            label = "Page_3";
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
    }
}
