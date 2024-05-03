﻿using Ferramas.Model.Domain;
using System.Security.Claims;
using System.Security.Principal;

namespace Ferramas.Extensions;

public static class AuthenticationExtension
{
    public const string Issuer = "Ferramas";

    public static ClaimsPrincipal CreatePrincipalIdentity(this FerraUser user)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier, $"{user.Surname}, {user.Name}", null, Issuer),
            new Claim(ClaimTypes.Name, user.Name, null, Issuer),
            new Claim(ClaimTypes.Surname, user.Surname, null, Issuer),
            new Claim(ClaimTypes.Email, user.Email, null, Issuer),
        };

        ClaimsIdentity identity = new(claims, "Basic");
        ClaimsPrincipal result = new(identity);

        return result;
    }

    public static bool IsAuthenticated(this HttpContext context)
    {
        IIdentity? identity = context
            .User
            .Identity;

        if (identity == null)
            return false;

        return identity.IsAuthenticated;
    }
}
