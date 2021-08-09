using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisedDL;
using RevisedDTO;

namespace RevisedBL
{
    public class BusinessLayer
    {
        DataLayer dalObj;
        public BusinessLayer()
        {
            dalObj = new DataLayer();
        }
        public int AddFaculty(int  PsNo, string Email,string Name)
        {
            try
            {
                return dalObj.AddFaculty(PsNo, Email, Name);
            }
            catch(Exception ex) {
                Console.WriteLine("Console Went Down :'(");
                return -1;
            }

        }
        public int AddCourse(string CourseID, string CourseTitle, int NoOfHours)
        {
            try
            {
                return dalObj.AddCourse(CourseID, CourseTitle, NoOfHours);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Console Went Down :'(");
                return -1;
            }

        }
        public int AddGraderDetails(int TotalMarks, string AreaOfImprovement, string CourseID, int ParticipantId)
        {
            try
            {
                return dalObj.AddGraderDetails(TotalMarks, AreaOfImprovement, CourseID, ParticipantId);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Console Went Down :'(");
                return -1;
            }
        }
    }
}
