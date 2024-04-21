using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayTravelAgency
{
    public class TravelAgency
    {
        private string name;
        private List<Customer> customers;
        private List<Tour> tours;
        private List<Trip> trips;

        public TravelAgency(string name)
        {
            this.name = name;
            customers = new List<Customer>();
            

            tours = new List<Tour>();
           

            trips = new List<Trip>();
            

        }
      
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(Tour tour)
        {
            tours.Add(tour);
        }

        public void Add(Trip trip) 
        { 
            trips.Add(trip);
        }

        public Tour FindTour(string city)
        {
            foreach(Tour tour in tours)
            {
                if(tour.Name.Equals(city))
                {
                    return tour;
                }
            }

            return null;
        }

        public Trip FindTrip(string city)
        {
            foreach(Trip trip in  trips)
            {
                if(trip.Tour.Name.Equals(city))
                {
                    return trip;
                }
            }

            return null;
        }

        public Customer FindCustomer(string name)
        {
            foreach (Customer customer in customers)
            {
                if(customer.Name.Equals(name))
                    return customer;
            }
            return null;
        }

        public void ListTours()
        {
            foreach(Tour tour in tours)
            {
                Console.WriteLine(tour);
            }
        }

        public void ListTrips()
        {
            foreach(Trip trip in trips)
            {
                Console.WriteLine(trip);
            }
        }

        public void MakeBooking(Customer c, Trip t, int n)
        {
            t.Book(c, n);
        }
    }
}
