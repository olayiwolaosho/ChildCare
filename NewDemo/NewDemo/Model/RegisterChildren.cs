using System;
using System.Collections.Generic;
using System.Text;

namespace NewDemo.Model
{
    public class RegisterChildren
    {

        public string Id { get; set; }
        public string Childname { get; set; }
        public string Password { get; set; }
        // public string Childpicture { get; set; }

        //Foreignkey
        public int AttendantId { get; set; }
    }
}
