using System;
using System.Collections.Generic;

namespace AnimatedSpice.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}