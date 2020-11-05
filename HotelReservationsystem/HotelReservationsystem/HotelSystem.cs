using System;
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
        public List<Hotel> GetCheapestBestRatedHotel(string[] dates)
        {
            List<Hotel> cheapestHotels = GetCheapestHotel(dates);
            cheapestHotels.Sort((e1, e2) => e1.rating.CompareTo(e2.rating));
            int highestRating = cheapestHotels.Last().rating;
            return cheapestHotels.FindAll(e => e.rating == highestRating);
        }
        public List<Hotel> GetBestRatedHotel(string[] dates)
        {
            DateTime[] validatedDates = dateValidation.ValidateAndReturnDates(dates);
            SetWeekendsAndWeekdays(validatedDates);

            hotelList.Sort((e1, e2) => e1.rating.CompareTo(e2.rating));
            int highestRating = hotelList.Last().rating;
            return hotelList.FindAll(e => e.rating == highestRating);
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
        public void DisplayHotels(List<Hotel> hotels)
        {
            int i = 1;
            Console.WriteLine("Hotels");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(i + ". " + hotel.name + "\tRating :" + hotel.rating + "\tTotal Rate :" + CalculateTotalRate(hotel));
                i++;
            }
        }
    }
}
