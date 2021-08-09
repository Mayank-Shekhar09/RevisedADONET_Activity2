using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisedDTO;
using RevisedBL;

namespace RevsiedUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer blfaculty, blcourse, blgrader;



            blfaculty = new BusinessLayer();
            Console.WriteLine("\nEnter FacultyName");
            var Name = Console.ReadLine();
            Console.WriteLine("\nEnter email");
            var EmailId = Console.ReadLine();
            Console.WriteLine("\nEnter Psno");
            var PSNo = Convert.ToInt32(Console.ReadLine());
            int result = blfaculty.AddFaculty(PSNo,EmailId,Name);
            if (result != -1)
            {
                Console.WriteLine($"Returned Value =" + result);
            }
            else
            {
                Console.WriteLine("Console Went Down :'(");
            }



            blcourse = new BusinessLayer();
            Console.WriteLine("\nEnter Courseid");
            var CourseID = Console.ReadLine();
            Console.WriteLine("\nEnter coursetitle");
            var CourseTitle = Console.ReadLine();
            Console.WriteLine("\nEnter Duration");
            int NoOfHours = Convert.ToInt32(Console.ReadLine());
            int result1 = blcourse.AddCourse(CourseID, CourseTitle,NoOfHours);
            if (result != -1)
            {
                Console.WriteLine($"Returned Value =" + result1);
            }
            else
            {
                Console.WriteLine("Console Went Down :'(");
            }

            

            blgrader = new BusinessLayer();
            Console.WriteLine("\nEnter Marks_Obtained");
            int TotalMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Feedback");
            var AreaOfImprovement = Console.ReadLine();
            Console.WriteLine("\nEnter ParticipantID");
            int ParticipantId = Convert.ToInt32(Console.ReadLine());
            int result2 = blgrader.AddGraderDetails(TotalMarks,AreaOfImprovement,CourseID, ParticipantId);
            if (result != -1)
            {
                Console.WriteLine($"Returned Value =" + result2);
            }
            else
            {
                Console.WriteLine("Console Went Down :'(");
            }
        }

    }

}

