using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class Product
    {
        //members
        // Properties,field
        public int code;
        public string name;
        public string desc;
        public string supplier;
        public float price;
        //method
        public string info()
        {
            return "Code :" + code + " Name : " + name + "Description " + desc + " Supplier :" + supplier + " Price :" + price;
        }

    }
}
