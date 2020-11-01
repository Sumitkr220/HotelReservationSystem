using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationsystem;
namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_NameAndRegularRates_Add_Hotel_To_List()
        {
            string hotelName = "Lakewood";
            int ratesForRegularCustomer = 100;
            HotelSystem hotelSystem = new HotelSystem();
            hotelSystem.AddHotel(new Hotel(hotelName, ratesForRegularCustomer));
            Assert.AreEqual(1, hotelSystem.hotelList.Count);
        }
    }
}
