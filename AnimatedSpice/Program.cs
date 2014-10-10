using System;
using System.Data.Entity;
using AnimatedSpice.DAL;

namespace AnimatedSpice
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Starting");

            using (var dbContext = new SchoolContext())
            {
                foreach (var student in dbContext.Students)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", student.ID, student.FirstMidName, student.LastName, student.EnrollmentDate);
                }
            }

            Console.ReadKey();

            return 0;
        }
    }
}
