﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationsystem
{
    public class DateValidation
    {
        public DateTime[] ValidateAndReturnDates(string[] enteredDates)
        {
            if (enteredDates == null)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.NULL_DATES, "Dates are null");
            }
            DateTime startDate = ConvertToDate(enteredDates[0]);
            DateTime endDate = ConvertToDate(enteredDates[1]);
            if (startDate > endDate || startDate < DateTime.Today)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE, "Dates are invalid");
            }

            TimeSpan t = endDate.Date - startDate.Date;
            int noOfDays = t.Days + 1;
            DateTime[] datesValidated = new DateTime[noOfDays];

            for (int i = 0; i < noOfDays; i++)
            {
                datesValidated[i] = startDate.AddDays(i);
            }

            return datesValidated;
        }
        public DateTime ConvertToDate(string enteredDate)
        {
            try
            {
                DateTime date = DateTime.Parse(enteredDate);
                return date;
            }
            catch (FormatException)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE_FORMAT, "Date Format is Invalid");
            }
        }
    }
}
