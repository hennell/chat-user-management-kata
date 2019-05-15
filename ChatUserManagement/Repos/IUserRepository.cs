namespace ChatUserManagement.Repos
{
    /// <summary>
    /// Interface is required so we can mock out the repo.
    /// </summary>
    public interface IUserRepository
    {
        string GetUserInfo(string id);
    }
}
