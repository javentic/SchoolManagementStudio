using System;
namespace SchoolManagementStudio.Data.TableModels
{
    public partial class Course
    {
        public Course()
        {
        }

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
    }
}
