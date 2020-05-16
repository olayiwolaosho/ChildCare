using System;
using System.Collections.Generic;
using System.Text;

namespace NewDemo.Model
{
    public class RegisterChildren
    {
        public int id { get; set; }
        public string Childname { get; set; }
        public string password { get; set; }
        // public string Childpicture { get; set; }

        //Foreignkey
        public int AttendantId { get; set; }
    }
}
