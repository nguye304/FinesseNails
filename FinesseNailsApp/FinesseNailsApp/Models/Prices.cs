using System;
using System.Collections.Generic;
using System.Text;

namespace FinesseNailsApp.Models
{
    public class Prices
    { 
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Price2 { get; set; }
        public string Description { get; set; }

    }
    public class PriceRootObject
    {
        public int count { get; set; }
        public List<Prices> PricesList { get; set; }
    }

}
