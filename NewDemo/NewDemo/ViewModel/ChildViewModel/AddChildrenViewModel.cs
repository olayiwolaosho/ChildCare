using NewDemo.Model;
using NewDemo.Services;
using NewDemo.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NewDemo.ViewModel.ChildViewModel
{
    class AddChildrenViewModel : BaseViewModel
    {
        public IDatastore<RegisterChildren> datastore => DependencyService.Get<IDatastore<RegisterChildren>>();

        

        string childname;
        public string ChildName
        {
            get => childname;
            set => SetProperty(ref childname, value);
        }

        string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        private RegisterChildren registerChildren()
        {
            var child = new RegisterChildren()
            {
                Id = Guid.NewGuid().ToString(),
                Childname = childname,
                Password = password,
            };
            return child;
        }

        private async Task<bool> PostChildtofirebase()
        {
            var registrered = registerChildren();
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var success = await datastore.AddItemAsync(registrered);
                return success;
            }
           
            return false;

        }

        public ICommand Save => new Command(async () =>
        {

            if (await PostChildtofirebase())
            {
               await App.Current.MainPage.DisplayAlert("Success", "Child has been added", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No Internet Access", "No Internet Access", "Ok");
            }

        });

    }
}
