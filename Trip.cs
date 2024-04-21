using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class Trip
    {
        private Tour tour;
        private DateTime datetime;
        private int maximum;
        private List<Booking> bookings;

        public Tour Tour
        {
            get { return tour; }
        }

      

        public Trip(Tour tour, DateTime datetime, int maximum)
        {
            this.tour = tour;
            this.datetime = datetime;
            this.maximum = maximum;
            bookings = new List<Booking>();
        }

        public void Book(Customer customer, int N)
        {

            if (Numbers + N > maximum)
            {
                throw new ApplicationException($"Addition of {N} seats exceeds the maximum size of Tranvellers");

            }

            
            bookings.Add(new Booking(this, customer, N));
        }

        public double GetRevenue()
        {
            double total = 0;
            foreach(Booking booking in bookings)
            {
                total += booking.Cost;
            }
            return total;
        }

        public int Numbers
        {
            get
            {
                int total = 0;
                foreach(Booking book in  bookings)
                {
                    total += book.NoOfTravellers;
                }
                return total;
            }
        }

        public override string ToString()
        {
            return string.Format("Trip(tour : {0}, DateTime : {1}, Maximum : {2})", tour, datetime, maximum);
        }
    }
}
