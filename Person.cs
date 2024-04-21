using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address;}
        }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
