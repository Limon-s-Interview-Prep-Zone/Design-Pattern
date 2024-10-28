using System;

namespace DecoratorPattern.Services
{
    public class AuthenticationDecorator : UserServiceAbstractDecorator
    {
        private readonly bool _isAuthenticated;

        public AuthenticationDecorator(IUserService innerService, bool isAuthenticated) : base(innerService)
        {
            _isAuthenticated = isAuthenticated;
        }

        public override string GetUserDetails(int userId)
        {
            if (!_isAuthenticated) throw new UnauthorizedAccessException("User is not authenticated.");

            Console.WriteLine("[AUTH] User is authenticated.");
            return base.GetUserDetails(userId);
        }
    }
}