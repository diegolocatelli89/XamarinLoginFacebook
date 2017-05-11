using LabSocialLogin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using LabSocialLogin.UWP.Auth;

[assembly: Xamarin.Forms.Dependency(typeof(AuthUWP))]
namespace LabSocialLogin.UWP.Auth
{
    public class AuthUWP : IAuth
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(provider);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
