using NewDemo.Model;
using NewDemo.Services;
using NewDemo.Services.IServices;
using NewDemo.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewDemo.ViewModel.AuthenticationViewModel
{
    class AttendantLoginViewModel : BaseViewModel
    {
        readonly IFirebaseAuthenticator firebaseAuthenticator;
        readonly NavigationServices navigationService;
        public AttendantLoginViewModel(IFirebaseAuthenticator firebaseAuthenticator,NavigationServices navigationService)
        {
            this.firebaseAuthenticator = firebaseAuthenticator;
            this.navigationService = navigationService;
        }

        string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        string email;
        public string EmailAddress
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public ICommand LoginNavigation => new Command(async () =>
        {

            bool isEmailEmpty = string.IsNullOrEmpty(email);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if(isEmailEmpty || isPasswordEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
            else
            {
                (Application.Current as App).AuthToken = await firebaseAuthenticator.LoginWithEmailPassword(email, password);
                if ((Application.Current as App).AuthToken is null)
                {
                    await App.Current.MainPage.DisplayAlert("Login Fail", "User not found", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                    await navigationService.PushAsync(new HomePage());
                }
                
            }

        }); 
        
        public ICommand ParentNavigation => new Command(async () =>
        {

           await navigationService.PushAsync(new ParentLogin());

        });
    }
}
