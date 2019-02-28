using System;
using System.Data.Entity;
using SchoolManagementStudio.Data.TableModels;

namespace SchoolManagementStudio.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("School")
        {
        }

        public DbSet<Student> Students { get; set; }

        // Methods
        public void AddStudent() { 
            using (var context = new SchoolContext()) {

                var student = new Student { 
                     ID = 0,
                     Type = "New"
                };

                context.Students.Add(student);
                context.SaveChanges();

            }
        }
    }
}
