using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class Tour
    {
        private string name;
        private int cost;
        private int duration;
        private List<string> places_of_interest;

        public void Add(string location)
        {
            places_of_interest.Add(location);
        }

        public string Name
        {
            get { return name; }
        }
         
        public virtual int Cost
        {
            get { return cost; }
        }

        public virtual int Duration
        {
            get { return duration; }
        }

        public Tour(string name, int cost, int duration)
        {
            this.name = name;
            this.cost = cost;
            this.duration = duration;

        }

        public Tour(string name, int cost, int duration, List<string> places_of_interest) : this(name, cost, duration)
        {
            this.places_of_interest = places_of_interest;
        }

        public override string ToString()
        {
            return string.Format("Tour(Name : {0}, Cost {1}, Duration : {2})", Name, Cost, Duration);
        }
    }
}
