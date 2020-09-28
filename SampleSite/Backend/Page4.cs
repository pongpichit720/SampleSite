using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSite.Backend
{
    public class Page4
    {
        private String color { get; set; }
        private String label { get; set; }
        private String description { get; set; }

        public Page4()
        {
            color = "seagreen";
            description = "something 2";
            label = "Page_4";
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
