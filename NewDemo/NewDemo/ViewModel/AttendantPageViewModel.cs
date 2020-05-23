using NewDemo.Model;
using NewDemo.Services;
using NewDemo.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewDemo.ViewModel
{
    class AttendantPageViewModel : BaseViewModel
    {
        public IDatastore<Attendant> datastore => DependencyService.Get<IDatastore<Attendant>>();

        INavigation navigation;

        public AttendantPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }
        string firstname;
        public string FirstName
        {
            get => firstname;
            set => SetProperty(ref firstname, value);
        }    
        
        string lastname;
        public string LastName
        {
            get => lastname;
            set => SetProperty(ref lastname, value);
        }

        string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }  
        
        string gender;
        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }  
        
        string number;
        public string Number
        {
            get => number;
            set => SetProperty(ref number, value);
        }

        private Attendant AddAttendant()
        {
            
            Attendant attendant = new Attendant()
            {
                id = Guid.NewGuid().ToString(),
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                EmailAddress = email,
                Mobilenumber = number,
            };

            return attendant;
        }

        private async Task<bool> Posttofirebase()
        {
            var attendant =  AddAttendant();
            var success = await datastore.AddItemAsync(attendant);
            return success;
        }

        public ICommand NavigateComman => new Command(async () =>
        {

            if(await Posttofirebase())
            {
                await navigation.PushAsync(new AttendantPage());
            }
            
        });
    }
}
