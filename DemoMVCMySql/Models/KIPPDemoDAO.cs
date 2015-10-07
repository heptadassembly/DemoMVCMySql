using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCMySql.Models
{
    public class KIPPDemoDAO
    {


        public ProfileModel LoginValidation(string UserID, string Password )
        {
            ProfileModel userProfile;
            using (var queryDB = new samsjacksonvilleEntities())
            {
               userProfile = queryDB.Database.SqlQuery<ProfileModel>("select * from profile where UserID = @p0 and Password = @p1", UserID, Password).FirstOrDefault< ProfileModel>();

            }

            return userProfile;
        }
            
        public List<StudentModel> GetStudents()
        {

            List<StudentModel> students = new List<StudentModel>();

            using (var queryDB = new samsjacksonvilleEntities())
            {

                IEnumerable<StudentModel> data = queryDB.Database.SqlQuery<StudentModel>("select * from student");
                students = data.ToList();
            }

            return students;
        }
    }
}