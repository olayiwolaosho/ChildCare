using Firebase.Database;
using NewDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.ViewModel
{
    class AttendantProfileViewModel
    {
        private FirebaseClient firebase;
        public AttendantProfileViewModel()
        {
            firebase = new FirebaseClient("https://logbook-day-care.firebaseio.com/");
        }

        public async Task<Attendant> GetAttendant(string email)
        {
            return (await firebase
              .Child("Persons")
              .OnceAsync<Attendant>()).Select(item => new Attendant
              {
                  EmailAddress = email,
              }).FirstOrDefault();
        }

        //public async Task<List<Attendant>> GetAllPersons()
        //{
        //    return (await firebase
        //  .Child("Attendant")
        //  .OnceAsync<Attendant>()).Select(item => new Attendant
        //  {

        //  }).ToList();

        //}
    }
}
