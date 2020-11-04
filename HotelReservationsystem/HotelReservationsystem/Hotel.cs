using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationsystem
{
    public class Hotel
    {
        public string name;
        public int weekdayRatesForRegularCustomer;
        public int weekendRatesForRegularCustomer;
        public Hotel()
        {
            name = "";
            weekdayRatesForRegularCustomer = 0;
            weekendRatesForRegularCustomer = 0;

        }
        public Hotel(string name, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = name;
            this.weekdayRatesForRegularCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForRegularCustomer = weekendRatesForRegularCustomer;
        }
    }
}
