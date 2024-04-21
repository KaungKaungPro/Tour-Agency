using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class TourPackage : Tour
    {
        private List<Tour> list_of_tour;

        public TourPackage(string TourPlace) : base(TourPlace, 0, 0)
        {
            list_of_tour = new List<Tour>();
        }

        public void ConsistOf(Tour t)
        {
            list_of_tour.Add(t);
        }

        public override int Cost
        {
            get
            {
                int total = 0;
                foreach (Tour t in list_of_tour)
                {
                    total += t.Cost;
                }

                return (int)(total * 0.9);
            }
        }

        public override int Duration
        {
            get
            {
                int totalDuration = 0;
                foreach (Tour t in list_of_tour)
                {
                    totalDuration += t.Duration;
                }

                return totalDuration;
            }
        }
    }

}
