using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NunitTesting;

namespace TestCases
{
   [TestFixture]
    public class TestClass
    {
        //Arrange
        Program pobj = new Program();
        Accounts acc;

        [SetUp]
        public void TestSetUp()
        {
            acc = new Accounts("12345");
        }

        [Test]
        public void Cancellation_ByAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanbeCancelledBy(new User { IsAdmin = true });

            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_By_MadeBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanbeCancelledBy(user);

            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_ByOthers_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanbeCancelledBy(new User());

            ClassicAssert.IsFalse(result);
        }
        [Test]
       // [Ignore("JunkVal")]
        public void TestDeposit()
        {
            acc.Deposit(1000);
           // ClassicAssert.AreEqual(2000, acc.CheckBalance());

            ClassicAssert.AreEqual(5000, acc.CheckBalance());
        }

        public void TestWithdrawal()
        {
            acc.Withdraw(2500);
        }

        [Test]

        public void TestWithdrawalException()
        {
            Assert.Throws<Exception>(TestWithdrawal);
        }
        [Test]
        public void TestTheLoginCredentials()
        {
            //Act
           string s1 = pobj.Login("Nidhi", "Admin@123");
            string s2 = pobj.Login("Ramya", "");
            string s3 = pobj.Login("Admin", "Admin@123");

            //Assert
            ClassicAssert.AreEqual("Incorrect UserId or Password", s1);
            ClassicAssert.AreEqual("UserId or Password Cannot be blank", s2);
            ClassicAssert.AreEqual("Welcome Admin", s3);

        }
        [Test]
        public void CheckEmployees()
        {
            //Arrange
            List<EmployeeDetails> empdetails;

            empdetails=pobj.AllUsers();
            foreach(var item in empdetails)
            {
                ClassicAssert.IsNotNull(item.ID);
                ClassicAssert.IsNotNull(item.Name);
                ClassicAssert.IsNotNull(item.Salary);
            }
        }

        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(20,50,60)]
        public void TestAddNumberswithTestcases(int n1,int n2, int expected)
        {
            int result = acc.Add(n1, n2);
            ClassicAssert.AreEqual(expected, result);
        }
    }
}
