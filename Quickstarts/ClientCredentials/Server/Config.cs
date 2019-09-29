using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    /// <summary>
    ///     Identity配置
    /// </summary>
    public class Config
    {
        /// <summary>
        ///     定义要保护的资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApiResources() {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }
        /// <summary>
        ///     定义授权客户端
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients() {
            return new List<Client>
            {
                new Client()
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials, //设置模式，客户端模式
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api1" }
                }
            };
        }
    }
}
