﻿namespace WebApp.Application.Services.Auth;

public class AuthService : IAuthService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        // throw new NotImplementedException();
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "token");
        // throw new NotImplementedException();
    }
}