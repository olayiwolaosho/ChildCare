using Firebase.Database;
using NewDemo.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewDemo.Services
{
    class FirebaseRegistration
    {
        FirebaseClient firebase = new FirebaseClient("https://logbook-day-care.firebaseio.com/");

        public IDatastore<AttendantLogin> datastore => DependencyService.Get<IDatastore<AttendantLogin>>();

        public Task<bool> AddItemAsync(AttendantLogin item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            
            throw new NotImplementedException();
        }

        public async Task<AttendantLogin> GettItemAsync(string email)
        {
            try
            {
                var allUsers = await GettItemsAsync();

                await firebase.Child("Users")
                .OnceAsync<AttendantLogin>();
                return allUsers.Where(a => a.EmailAddress == email).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        

        public async Task<IEnumerable<AttendantLogin>> GettItemsAsync()
        {
            try
            {
                var firebaseObject = await firebase
                .Child("Users").OnceAsync<AttendantLogin>();

                return firebaseObject.Select(item => new AttendantLogin
                {

                  
                    EmailAddress = item.Object.EmailAddress,
                    Password = item.Object.Password
                });
            }
            catch
            {
                return null;
            }
           
        }

        public Task<bool> UpdateItemAsync(AttendantLogin item)
        {
            throw new NotImplementedException();
        }
    }
}
