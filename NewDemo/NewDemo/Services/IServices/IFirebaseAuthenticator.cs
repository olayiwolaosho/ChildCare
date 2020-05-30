using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Services.IServices
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string email, string password);
    }
}
