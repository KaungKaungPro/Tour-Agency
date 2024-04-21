using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{

    public class Customer : Person
    {
        
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Customer(string name, string address, string id) : base(name, address)
        {
            Id = id;
        }
    }
}
