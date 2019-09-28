using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;


namespace Server
{
    public class Config
    {
        /// <summary>
        ///     定义要保护的资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApiResources() {
            return new List<ApiResource>
            {
               new ApiResource("api1","MyApi")
            };
        }
        /// <summary>
        ///     定义授权客户端
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients() {
            return new List<Client>
            {
                new Client(){ 
                    ClientId="client",
                    AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                    AccessTokenLifetime=60,
                    ClientSecrets=
                    {
                      new Secret("secret".Sha256())
                    },
                    AllowedScopes={ "api1",IdentityServerConstants.StandardScopes.OfflineAccess //如果要获取refresh_tokens ,必须在scopes中加上OfflineAccess
                    },
                    AllowOfflineAccess=true// 主要刷新refresh_token,
          
                }
            };
        }
    }
}
