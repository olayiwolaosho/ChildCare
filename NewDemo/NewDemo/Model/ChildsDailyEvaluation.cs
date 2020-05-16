using System;
using System.Collections.Generic;
using System.Text;

namespace NewDemo.Model
{
    class ChildsDailyEvaluation
    {
        public int Id { get; set; }
        public string Behaiour { get; set; }
        public string Habit { get; set; }
        public string Medication { get; set; }

        //Foreignkey
        public int ChildId { get; set; }

        public DateTime Day { get; set; }
    }
}
