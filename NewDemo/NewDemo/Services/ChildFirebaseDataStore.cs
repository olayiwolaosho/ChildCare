using Firebase.Database;
using Firebase.Database.Query;
using NewDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Services
{
    public class ChildFirebaseDataStore : IDatastore<RegisterChildren>
    {
        FirebaseClient firebase = new FirebaseClient("https://logbook-day-care.firebaseio.com/");

        //   private readonly ChildQuery query;
        public async Task<bool> AddItemAsync(RegisterChildren item)
        {
            try
            {
                await firebase
             .Child("Child")
             .PostAsync(item);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterChildren> GettItemAsync(string id)
        {
            try
            {
                var item = await firebase.Child("Child").Child(id)
                    .OnceSingleAsync<RegisterChildren>();
                item.Id = id;
                return item;

                //var allPersons = await GettItemsAsync();
                //await firebase
                //  .Child("Attendant")
                //  .OnceAsync<Attendant>();
                //return allPersons.Where(a => a.id == id).FirstOrDefault();
            }
            catch
            {
                return null;
            }

        }

        public async Task<IEnumerable<RegisterChildren>> GettItemsAsync()
        {

            try
            {
                var firebaseObject = await firebase.Child("Child")
                    .OnceAsync<RegisterChildren>();

                return firebaseObject.Select(x => new RegisterChildren
                {
                    
                    Id = x.Key,
                     AttendantId = x.Object.AttendantId,
                     Childname = x.Object.Childname,
                     Password = x.Object.Password,
                });
            }
            catch
            {
                return null;
            }

            //return (await firebase
            //  .Child("Persons")
            //  .OnceAsync<Attendant>()).Select(item => new Attendant
            //  {
            //      Name = item.Object.Name,
            //      PersonId = item.Object.PersonId
            //  }).ToList();
        }

        public async Task<bool> UpdateItemAsync(RegisterChildren item)
        {
            throw new NotImplementedException();
        }
    }
}
