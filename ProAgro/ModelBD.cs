using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentiId { get; set; }

        public string Name { get; set; }

        public string Telefone { get; set; }

        public virtual List<Subject> Sunbjects { get; set; }

        public Student()
        {
            this.Sunbjects = new List<Subject>();
        }
    }
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public virtual Student Student { get; set; }
    }

    class StudentContext : DbContext
    {
        public StudentContext(): base("StudentDB") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

}
