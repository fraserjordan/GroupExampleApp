using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace GroupExampleApp
{
    public class AuthenticationHelper
    {
        public async Task<string> GetGraphAccessToken(string resource = null)
        {
            var authenticationContext = new AuthenticationContext("https://login.windows.net/tenant.onmicrosoft.com/");
            var authenticationResult = await authenticationContext.AcquireTokenAsync("https://graph.microsoft.com", GetClientCredential());
            return authenticationResult.AccessToken;
        }

        public ClientCredential GetClientCredential()
        {
            return new ClientCredential("ClientID", "ClientSecret");
        }
    }
}
