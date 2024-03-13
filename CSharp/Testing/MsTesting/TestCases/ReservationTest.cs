using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTesting;

namespace TestCases
{
    [TestClass]
    public class ReservationTest
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Debug.WriteLine("BeforeAssembly");
        }
        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Debug.WriteLine("After Assembly");
        }

        [ClassInitialize]

        // the method marked with classinitialize has to be static and should be passed with
        // a testcontext object
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("Called Before class");
        }
        [ClassCleanup]
        public static void AfterClass()
        {
            Debug.WriteLine("Called after the class");
        }
        [TestMethod]
        public void Cancellation_ByAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanbeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_By_MadeBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanbeCancelledBy(user);

          Assert.IsTrue(result);
        }

        [TestMethod]

        public void Cancellation_ByOthers_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanbeCancelledBy(new User());

           Assert.IsFalse(result);
        }

        [TestInitialize]
        public void BeforeRunningTests()
        {
            Console.WriteLine("This is before the test");
        }


    }
}
