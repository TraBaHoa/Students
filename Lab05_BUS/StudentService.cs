using Lab05_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Migrations;
namespace Lab05_BUS
{
    public class Student
    {
        public string AverageScore;
        public object Faculty;
        public object Major;
        public object StudentID;

        public object FullName { get; set; }
        public string MajorName { get; set; }

        public List<Lab05_DAL.Entities.Student> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }
        public List<Lab05_DAL.Entities.Student> GetAllHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Lab05_DAL.Entities.Student> GetAllHasNoMajorID(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Lab05_DAL.Entities.Student FindByID(string studentID)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }

        public void InsertUpdate(Lab05_DAL.Entities.Student s)
        {
            StudentModel context = new StudentModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }


        
    }
}
