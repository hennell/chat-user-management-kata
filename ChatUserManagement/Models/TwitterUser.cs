using System;

namespace ChatUserManagement.Models
{
    /// <summary>
    /// This class is here just to demonstrate we can have additional User types with
    /// unique properties (like TwitterHandle).
    /// </summary>
    public class TwitterUser : User
    {
        public string TwitterHandle { get; set; }

        public override void GetUserInfo()
        {
            throw new NotImplementedException();
        }
    }
}
