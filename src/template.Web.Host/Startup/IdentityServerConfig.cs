using System.Collections.Generic;
using System.Linq;
using IdentityServer4.Models;

public static class IdentityServerConfig
{
    public static IEnumerable<ApiResource> GetApiResources()
    {
        return new List<ApiResource>
        {
            new ApiResource("default-api", "Default (all) API")
        };
    }

    public static IEnumerable<IdentityResource> GetIdentityResources()
    {
        return new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Phone()
        };
    }

    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials
                                    .Union(GrantTypes.ResourceOwnerPassword)
                                    .Union(GrantTypes.CodeAndClientCredentials)
                                    .Union(GrantTypes.Code)
                                    .ToList(),
                AllowedScopes = {"default-api"},
                RedirectUris = new List<string>{
                    "http://localhost:21021/swagger/oauth2-redirect.html"
                },
                ClientSecrets =
                {
                    new Secret("secret")
                }
            }
        };
    }
}