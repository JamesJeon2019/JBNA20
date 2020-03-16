using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemaTest
{
    [TestClass]
    public class CinemaMsTest
    {
        [TestMethod]
        public void TicketCalculAccordAge()
        {
            //arrange
            int age = 19;
            int price = 80;
            int expected = 80;
            
            //act
            cinema p = new cinema();
            int actual = p.Price(age, price);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
