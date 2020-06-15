using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab14_Code_1st_.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}