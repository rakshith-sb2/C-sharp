using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    internal class Customer
    {
        // member variables
        int id;
        string name;
        string email;
        string mobile;
        string city;
        // prop tab tab
        //public int MyProperty { get; set; }
        public int zipcode { get; set; }
        public string country { get; set; }
        /*
         * Constructure
         * 
         */
        public Customer(int id,string name,string email, string mobile, string city)        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.city = city;
        }

        public String info()
        {
            return $"Id : {id} Name : {name} Email: {email} Mobile: {mobile}  City: {city}";
        }

    }
}
