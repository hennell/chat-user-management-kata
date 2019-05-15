using ChatUserManagement.Repos;

namespace ChatUserManagement.Tests.Fakes
{
    public class FakeSlackUserRepository : IUserRepository
    {
        public string GetUserInfo(string id)
        {
            string text = "{ " +
            "\"ok\": true," +
            "\"user\": {" +
            "  \"id\": \"ABC123\"," +
            "  \"team_id\": \"TEAM1234\"," +
            "  \"real_name\": \"Test User\"" +
            "  }" +
            "}";

            return text;
        }
    }
}
