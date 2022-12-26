using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProj.Models
{
    
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string supplier { get; set; }
        public int price { get; set; }

        public Product()
        {
        }

        public Product(int id,string name,string desc,string supplier,int price)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.supplier = supplier;
            this.price = price;
        }

    }


}