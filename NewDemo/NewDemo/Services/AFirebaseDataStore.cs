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
    public class AttendantFirebaseDataStore : IDatastore<Attendant>
    {
        FirebaseClient firebase = new FirebaseClient("https://logbook-day-care.firebaseio.com/");

     //   private readonly ChildQuery query;
        public async Task<bool> AddItemAsync(Attendant item)
        {
            try
            {
                await firebase
             .Child("Attendant")
             .PostAsync(item);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }



        public async Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Attendant> GettItemAsync(string id)
        {
            try
            {
                var item = await firebase.Child("Attendant").Child(id)
                    .OnceSingleAsync<Attendant>();
                item.id = id;
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

        public async Task<IEnumerable<Attendant>> GettItemsAsync()
        {

            try
            {
                var firebaseObject = await firebase.Child("Attendant")
                    .OnceAsync<Attendant>();

                return firebaseObject.Select(x => new Attendant
                {
                   id = x.Key,
                   FirstName = x.Object.FirstName,
                   LastName = x.Object.LastName,
                   EmailAddress = x.Object.EmailAddress,
                   Mobilenumber = x.Object.Mobilenumber,
                   Gender = x.Object.Gender
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

        public async Task<bool> UpdateItemAsync(Attendant item)
        {
            throw new NotImplementedException();
        }
    }
}
