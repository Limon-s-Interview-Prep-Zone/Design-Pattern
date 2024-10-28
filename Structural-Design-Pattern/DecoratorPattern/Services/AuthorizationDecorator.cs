using System;

namespace DecoratorPattern.Services
{
    public class AuthorizationDecorator : UserServiceAbstractDecorator
    {
        private readonly string _requiredRole;
        private readonly string _userRole;

        public AuthorizationDecorator(IUserService innerService, string userRole, string requiredRole) : base(
            innerService)
        {
            _userRole = userRole;
            _requiredRole = requiredRole;
        }

        public override string GetUserDetails(int userId)
        {
            if (_userRole != _requiredRole)
                throw new UnauthorizedAccessException("User does not have the required permissions.");

            Console.WriteLine($"[AUTHZ] User has '{_userRole}' role, access granted.");
            return base.GetUserDetails(userId);
        }
    }
}