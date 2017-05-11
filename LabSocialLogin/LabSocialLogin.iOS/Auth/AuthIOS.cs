using LabSocialLogin.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using LabSocialLogin.iOS.Auth;

[assembly: Xamarin.Forms.Dependency(typeof(AuthIOS))]
namespace LabSocialLogin.iOS.Auth
{
    public class AuthIOS : IAuth
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(UIKit.UIApplication.SharedApplication.KeyWindow.RootViewController, provider);
            }
            catch (Exception er)
            {
                return null;
            }
        }
    }
}
