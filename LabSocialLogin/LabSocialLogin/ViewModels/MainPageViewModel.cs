using LabSocialLogin.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabSocialLogin.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public string Info
        {
            get { return _info; }
            set
            {
                _info = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Info"));
            }
            
        }

        private string _info = "Não logado";


        readonly AzureServices serv;

        public Command LoginCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            serv = new AzureServices();
            LoginCommand = new Command(ExecuteCommandLogin);
        }

        private async void ExecuteCommandLogin()
        {
            var user = await serv.LoginAsync();
            Info = user != null ? $"Bem vindo {user.UserId}." : "Não foi possível efetuar login.";
        }


    }
}
