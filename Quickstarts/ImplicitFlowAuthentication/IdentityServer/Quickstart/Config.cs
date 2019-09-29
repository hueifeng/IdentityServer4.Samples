using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Quickstart
{
    public class Config
    {
        /// <summary>
        ///     定义身份资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };
        }
        /// <summary>
        ///     定义授权客户端
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client{
                ClientId="mvc",
                ClientName="MyClient",
                AllowedGrantTypes=GrantTypes.Implicit,
                RedirectUris = { "http://localhost:5003/signin-oidc" },//跳转登录到的客户端的地址
                 PostLogoutRedirectUris = { "http://localhost:5003/signout-callback-oidc" },//跳转登出到的客户端的地址
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email
                 },
              //  RequireConsent=true

                }
            };

        }



    }
}
