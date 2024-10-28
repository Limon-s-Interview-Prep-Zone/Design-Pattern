namespace DecoratorPattern.Services
{
    public abstract class UserServiceAbstractDecorator : IUserService
    {
        private readonly IUserService _innerService;

        protected UserServiceAbstractDecorator(IUserService innerService)
        {
            _innerService = innerService;
        }

        public virtual string GetUserDetails(int userId)
        {
            return _innerService.GetUserDetails(userId);
        }
    }
}