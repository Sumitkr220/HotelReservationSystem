﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationsystem
{
    public class HotelSystem
    {
        int weekday;
        int weekend;
        DateValidation dateValidation = new DateValidation();
        public List<Hotel> hotelList;
        public HotelSystem()
        {
            hotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            hotelList.Add(hotel);
        }
        public List<Hotel> GetCheapestHotel(string[] dates)
        {
            int i = 0;
            int rate = 0;
            List<Hotel> cheapestHotels = new List<Hotel>();

            DateTime[] validatedDates = dateValidation.ValidateAndReturnDates(dates);
            SetWeekendsAndWeekdays(validatedDates);

            foreach (Hotel hotel in hotelList)
            {
                int totalRate = CalculateTotalRate(hotel);
                i++;
                if (i == 1)
                    rate = totalRate;
                if (totalRate == rate)
                    cheapestHotels.Add(hotel);
                if (totalRate < rate)
                {
                    rate = totalRate;
                    cheapestHotels.Clear();
                    cheapestHotels.Add(hotel);
                }
            }
            return cheapestHotels;
        }
        public int CalculateTotalRate(Hotel hotel)
        {
            return (weekday * hotel.weekdayRatesForRegularCustomer) + (weekend * hotel.weekendRatesForRegularCustomer);
        }
        public void SetWeekendsAndWeekdays(DateTime[] dates)
        {
            weekday = 0;
            weekend = 0;

            foreach (DateTime date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Saturday)
                    weekend++;
                else
                    weekday++;
            }
        }
        public void DisplayHotels(Hotel[] hotels)
        {
            for (int i = 1; i <= hotels.Length; i++)
            {
                Console.WriteLine(i + ". " + hotels[i - 1].name);
            }
            Console.WriteLine("Rate :" + CalculateTotalRate(hotels[0]));
        }
    }
}
