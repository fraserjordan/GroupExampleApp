using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeDevPnP.Core.Framework.Graph;

namespace GroupExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var authHelper = new AuthenticationHelper();
            var accessToken = authHelper.GetGraphAccessToken().Result;

            var groupSettings = new
            {
                AllowExternalSenders = false,
                AutoSubscribeNewMembers = false
            };

            GraphHttpClient.MakePatchRequestForString(
                $"{GraphHttpClient.MicrosoftGraphV1BaseUri}groups/0dd7fae1-53b3-4423-8032-25f66a70870c",
                groupSettings, "application/json", accessToken
            );
        }
    }
}
