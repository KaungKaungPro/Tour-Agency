using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class TourGuide : Person
    {
       
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public TourGuide(string name, string address, int salary) : base(name, address)
        {
            Salary = salary;
        }
    }

}
