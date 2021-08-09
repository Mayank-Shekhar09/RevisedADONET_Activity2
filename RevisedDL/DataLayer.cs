using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisedDTO;

namespace RevisedDL
{
	public class DataLayer
	{
        SqlConnection sqlObj;
        SqlCommand sqlCmdObj;
        public DataLayer()
        {
            sqlObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ToString());
        }
        public int AddFaculty(int PSNo, string EmailId, string NAME)
        {

            sqlCmdObj = new SqlCommand("uspInsertFaculty", sqlObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@PSNo", PSNo);
            sqlCmdObj.Parameters.AddWithValue("@EmailId", EmailId);
            sqlCmdObj.Parameters.AddWithValue("@Name",NAME);
            
            try
            {
                sqlObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                // rowAff = sqlCmObj.ExecuteNonQuery(); //Number of rows Affected.
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Console Went Down :'(");
                return -1;

            }
            finally
            {
                sqlObj.Close();
            }
        }

        public int AddCourse(string CourseID, string CourseTitle, int NoOFHours)
        {

            sqlCmdObj = new SqlCommand("uspInsertCourse", sqlObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@CourseID", CourseID);
            sqlCmdObj.Parameters.AddWithValue("@CourseTitle", CourseTitle);
            sqlCmdObj.Parameters.AddWithValue("@NoOfHours",NoOFHours);
   
            try
            {
                sqlObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Console Went Down :'(");
                return -1;


            }
            finally
            {
                sqlObj.Close();
            }
        }

        public int AddGraderDetails(int TotalMarks, string AreaOfImprovement, string CourseID, int ParticipantId)
        {

            sqlCmdObj = new SqlCommand("uspInsertGrader", sqlObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@TotalMarks",TotalMarks);
            sqlCmdObj.Parameters.AddWithValue("@AreaOfImprovement", AreaOfImprovement);
            sqlCmdObj.Parameters.AddWithValue("@CourseID", CourseID);
            sqlCmdObj.Parameters.AddWithValue("@ParticipantId", ParticipantId);
            try  
            {
                sqlObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Console Went Down :'(");
                return -1;

            }
            finally
            {
                sqlObj.Close();
            }
        }
    }
}
