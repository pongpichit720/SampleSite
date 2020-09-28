using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace SampleSite.Backend
{

    public class Page1
    {
        private String color { get; set; }
        private String label { get; set; }
        private String description { get; set; }

        public Page1()
        {
            color = "crimson";
            description = "pictures";
            label = "Page_1";
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

        public String[] GetImages()
        {
            String[] images = {
                "https://www.w3schools.com/css/img_lights.jpg",
                "https://www.w3schools.com/css/img_forest.jpg",
                "https://www.w3schools.com/css/img_5terre.jpg",
                "https://www.w3schools.com/css/img_mountains.jpg",
            };
            return images;
        }
    }
}
