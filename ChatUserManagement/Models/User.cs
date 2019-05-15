namespace ChatUserManagement.Models
{
    /// <summary>
    /// User is an abstract class and GetUserInfo must be overridden in concreate clases.
    /// </summary>
    public abstract class User
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public abstract void GetUserInfo();
    }
}