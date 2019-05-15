using ChatUserManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatUserManagement.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        /// <summary>
        /// This integration test will use the real SlackUserRepository to make a live call to the Slack API.
        /// </summary>
        [TestMethod]
        public void GetSlackUserInfo()
        {
            // Arrange
            var user = new SlackUser
            {
                Id = "UJMJSNEJG" // Slack seems to be getting rid of their UserName, so had to use MemberId.
            };

            // Act
            user.GetUserInfo();

            // Assert
            Assert.AreEqual("UJMJSNEJG", user.Id);
            Assert.AreEqual("Bill Hennell", user.FullName);
            Assert.AreEqual("TJQ9V0TAA", user.TeamId);
        }

    }
}
