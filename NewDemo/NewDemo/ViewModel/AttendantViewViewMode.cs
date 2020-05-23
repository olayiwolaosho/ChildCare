using NewDemo.Model;
using NewDemo.Services;
using NewDemo.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewDemo.ViewModel
{
    class AttendantViewViewMode : BaseViewModel
    {
        public IDatastore<Attendant> datastore => DependencyService.Get<IDatastore<Attendant>>();

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

        private async Task GetAttendantFromFB()
        {
          
        }
    }
}
