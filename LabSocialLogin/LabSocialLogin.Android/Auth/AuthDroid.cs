using LabSocialLogin.Auth;
using LabSocialLogin.Droid.Auth;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AuthDroid))]
namespace LabSocialLogin.Droid.Auth
{
    public class AuthDroid : IAuth
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(Xamarin.Forms.Forms.Context, provider);
            }
            catch (Exception er)
            {
                return null;
            }
        }
    }
}