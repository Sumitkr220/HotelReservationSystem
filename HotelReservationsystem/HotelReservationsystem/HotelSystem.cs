using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationsystem
{
    public class HotelSystem
    {
        public List<Hotel> hotelList;
        DateValidation dateValidation = new DateValidation();
        public HotelSystem()
        {
            hotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            hotelList.Add(hotel);
        }
        public Hotel GetCheapestHotel(string[] enteredDates)
        {
            DateTime[] dates = dateValidation.ValidateDates(enteredDates);
            hotelList.Sort((e1, e2) => e1.ratesForRegularCustomer.CompareTo(e2.ratesForRegularCustomer));
            return hotelList.First();
        }
    }
}
