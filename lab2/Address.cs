using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Address
    {
        private string index;
        public string Index { get=>index; set=>index=value; }
        private  string country;

        public  string Country 
        {
            get { return country; }
            set { country = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string house;

        public string House
        {
            get { return house; }
            set { house = value; }
        }
        private int apartment;

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {House}, {Apartment}";
        }





    }
}
