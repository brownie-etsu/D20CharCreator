using System;
using D20CharCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace D20CharCreatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsernameExistsReturnsTrueIfUsernameExists()
        {
            string username = "ValidUsername";

            bool usernameExists = Database.UsernameExists(username);

            Assert.IsTrue(usernameExists);
        }

        [TestMethod]
        public void UsernameExistsReturnsFalseIfUsernameDoesNotExist()
        {
            string username = "InvalidUsername";

            bool usernameExists = Database.UsernameExists(username);

            Assert.IsFalse(usernameExists);
        }

        [TestMethod]
        public void EmailExistsReturnsTrueIfEmailExists()
        {
            string email = "test@test.test";

            bool emailExists = Database.EmailExists(email);

            Assert.IsTrue(emailExists);
        }

        [TestMethod]
        public void EmailExistsReturnsFalseIfEmailDoesNotExist()
        {
            string email = "DoesNotExist@fail.fail";

            bool emailExists = Database.EmailExists(email);

            Assert.IsFalse(emailExists);
        }


    }
}
