using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitTesting;

namespace TestCases
{
   [TestFixture]
    public class TestClass
    {
        //Arrange
        Program pobj = new Program();

        [Test]
        public void TestTheLoginCredentials()
        {
            //Act
           string s1 = pobj.Login("Nidhi", "N111");
            string s2 = pobj.Login("", "");
            string s3 = pobj.Login("Admin", "Admin@123");

            //Assert
            Assert.Equals("Incorrect UserId or Password", s1);
            Assert.Equals("UserId or Password Cannot be blank", s2);
            Assert.Equals("Welcome Admin", s3);

        }
        [Test]
        public void NoTest()
        {

        }

    }
}
