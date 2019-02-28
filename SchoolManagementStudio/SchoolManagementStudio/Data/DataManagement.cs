using System;
using System.Collections.Generic;
using SchoolManagementStudio.Data.TableModels;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace SchoolManagementStudio.Data
{
    public class DataManagement
    {
        public DataManagement()
        {
        }

        public static List<Course> GetAllCourses() {

            string connString = ConfigurationManager.ConnectionStrings["School"].ToString();
            List<Course> courses = new List<Course>();

            // Calling Stored Procedure
            using (var con = new SqlConnection(connString))
            {
                using (var cmd = new SqlCommand("stp_GetAllCourses", con))
                {
                    var dt = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    var c = JsonConvert.SerializeObject(dt);
                    courses = JsonConvert.DeserializeObject<List<Course>>(c);


                }

            }



            return new List<Course>();
        }
    }
}
