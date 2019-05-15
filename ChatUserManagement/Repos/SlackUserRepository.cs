using RestSharp;

namespace ChatUserManagement.Repos
{
    /// <summary>
    /// Slack specific implementation of the UserRepository interface.
    /// </summary>
    public class SlackRepository : IUserRepository
    {
        public string GetUserInfo(string id)
        {
            // Obviously, this should go in a config file or key vault.
            var slackToken = "xoxp-636335027350-633638762628-636434619142-8527563a1ce5a780c79506b430dbaec1";

            // Using RestSharp to make a simple REST call to the Slack API.
            var client = new RestClient("https://slack.com/api");
            var request = new RestRequest($"users.info?token={slackToken}&user={id}&pretty=1", Method.POST);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
