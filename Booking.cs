using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HolidayTravelAgency
{
    public class Booking
    {
        private Trip trip;
        private Customer customer;
        private int noOfTravellers;

        public Trip TheTrip
        {
            get { return trip; }
        }

        public Customer TheCustomer
        {
            get { return customer; }
        }

        public int NoOfTravellers
        {
            get { return noOfTravellers; }
        }

        public Booking(Trip trip, Customer customer, int noOfTravellers)
        {
            this.trip = trip;
            this.customer = customer;
            this.noOfTravellers = noOfTravellers;
        }

        public Booking(Customer customer, Trip trip) : this(trip, customer, 1)
        {

        }

        public virtual double Cost
        {
            get
            {
                double totalAmount = trip.Tour.Cost * noOfTravellers;
                if (noOfTravellers > 5)
                {
               
                    return totalAmount * 0.95;
                }
                return totalAmount;
            }
        }



        
    }

}
