using ChatUserManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatUserManagement.Tests
{
    [TestClass]
    public class SlackUserTests
    {
        /// <summary>
        /// This unit test uses the fake repo so there are no external dependencies.
        /// </summary>
        [TestMethod]
        public void GetSlackUserInfo()
        {
            // Arrange
            var _fakeUserRepository = new Fakes.FakeSlackUserRepository();
            var user = new SlackUser(_fakeUserRepository)
            {
                Id = "ABC123"
            };

            // Act
            user.GetUserInfo();

            // Assert
            Assert.AreEqual("ABC123", user.Id);
            Assert.AreEqual("Test User", user.FullName);
        }

    }
}
