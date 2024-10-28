namespace DecoratorPattern.Services
{
    public class UserService : IUserService
    {
        public string GetUserDetails(int userId)
        {
            return $"User {userId}: Limon, Role: Admin";
        }
    }
}