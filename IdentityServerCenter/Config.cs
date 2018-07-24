namespace IdentityServerCenter
{
    using System.Collections.Generic;
    using IdentityServer4.Models;
    using IdentityServer4.Test;
    public class Config
    {
        public static IEnumerable<ApiResource> GetResouces()
        {
            return new List<ApiResource>()
            {
                new ApiResource("api","My api")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId ="client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api"}
                },
                new Client()
                {
                    ClientId ="pwdClient",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api"}
                }
            };
        }

        public static List<TestUser> GetTestUser()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "xink",
                    Password = "123456"
                }
            };
        }
    }

}