﻿namespace WebApp.Contracts.Auth;

public record LoginRequest
(
    string Email,
    string Password
);

