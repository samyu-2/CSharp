using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract class Admission
    {
        public string StudentName;
        public int Age;

        public abstract void ApplyForAdmission();
        public abstract void ShowStudentDetails();

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to XYZ Institution Admission Portal!");
        }
    }

    class SchoolStudent : Admission
    {
        public string Grade;

        public override void ApplyForAdmission()
        {
            Console.WriteLine($"{StudentName} applied admission for {Grade} grade");
        }
        public override void ShowStudentDetails()
        {
            Console.WriteLine($"Student Name: {StudentName}\nAge: {Age}\nGrade: {Grade}");
        }
    }

    class CollegeStudent : Admission
    {
        public string Department;

        public override void ApplyForAdmission()
        {
            Console.WriteLine($"{StudentName} applied admission for {Department} Department");
        }

        public override void ShowStudentDetails()
        {
            Console.WriteLine($"Student Name: {StudentName}\nAge: {Age}\nDepartment: {Department}");
        }
    }
    class Abstract
    {
        public static void Display()
        {
            SchoolStudent student1 = new SchoolStudent();
            student1.StudentName = "Alice";
            student1.Age = 13;
            student1.Grade = "8th";

            student1.WelcomeMessage();
            student1.ApplyForAdmission();
            student1.ShowStudentDetails();
            Console.WriteLine();

            CollegeStudent collegeStudent = new CollegeStudent();
            collegeStudent.StudentName = "Charlie";
            collegeStudent.Age = 20;
            collegeStudent.Department = "IT";

            collegeStudent.WelcomeMessage();
            collegeStudent.ApplyForAdmission();
            collegeStudent.ShowStudentDetails();

        }
    }
}
