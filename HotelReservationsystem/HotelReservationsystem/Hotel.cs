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
        public int weekdayRatesForRewardCustomer;
        public int weekendRatesForRewardCustomer;
        public int rating;
        public Hotel()
        {
            name = "";
            weekdayRatesForRegularCustomer = 0;
            weekendRatesForRegularCustomer = 0;
            weekdayRatesForRewardCustomer = 0;
            weekendRatesForRewardCustomer = 0;
            rating = 0;
        }
        public Hotel(string name, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer, int weekdayRatesForRewardCustomer, int weekendRatesForRewardCustomer, int rating)
        {
            this.name = name;
            this.weekdayRatesForRegularCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForRegularCustomer = weekendRatesForRegularCustomer;
            this.weekdayRatesForRewardCustomer = weekdayRatesForRewardCustomer;
            this.weekendRatesForRewardCustomer = weekendRatesForRewardCustomer;
            this.rating = rating;
        }
    }
}
