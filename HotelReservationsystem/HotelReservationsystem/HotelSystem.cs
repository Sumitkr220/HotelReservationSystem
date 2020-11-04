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
        public Hotel GetCheapestHotel(string[] dates)
        {
            DateTime[] validatedDates = dateValidation.ValidateAndReturnDates(dates);
            hotelList.Sort((e1, e2) => e1.weekdayRatesForRegularCustomer.CompareTo(e2.weekdayRatesForRegularCustomer));
            return hotelList.First();
        }
    }
}
