using ChatUserManagement.Repos;
using Newtonsoft.Json.Linq;

namespace ChatUserManagement.Models
{
    /// <summary>
    /// SlackUser inherits from User and extends the properties and behavior with
    /// its own implementation of GetUserInfo.
    /// </summary>
    public class SlackUser : User
    {
        private readonly IUserRepository _userRepository;

        // Poor man's dependency injection so we can mock out when unit testing.
        public SlackUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public SlackUser()
        {
            _userRepository = new SlackRepository();
        }

        // SlackUser class is extended with an additional "TeamId" property unique to Slack.
        public string TeamId { get; set; }

        // This is the overridden implementation of the base abstract method GetUserInfo.
        public override void GetUserInfo()
        {
            var jsonString = _userRepository.GetUserInfo(Id);
            var jObject = JObject.Parse(jsonString);
            JToken jUser = jObject["user"];

            Id = (string)jUser["id"];
            FullName = (string)jUser["real_name"];
            TeamId = (string)jUser["team_id"];
        }
    }
}
