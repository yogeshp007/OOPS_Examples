using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace OOPS_Examples
{

    /// <summary>
    /// Class, object, Inheritance, Encapsulation, access modifiers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.LoadAppHeader();
            student.LoadOperations();
        }
    }

    /// <summary>
    /// It store infromations about students
    /// </summary>
    class Student
    {
        int studentId;
        string StudentName;

        //used to store students info
        List<Student> students = new List<Student>();

        public void LoadAppHeader()
        {
            Console.Title = "Student Registration Console Application";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\t\t\t\t WELCOME TO STUDENT REGISTRATION APPLICATION");
            Console.WriteLine("\t\t\t\t -------------------------------------------");
            Console.WriteLine("\n");
        }

        public void LoadOperations()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t a - Add New Student Information");
            Console.WriteLine("\t b - View Recently Added Student Information");
            Console.WriteLine("\t 3 - View All Student Information");
            Console.WriteLine("\t d - Delete All Student information");
            Console.Write("Your option? \n");

            // Use a switch statement to do all operations.


            var option = Console.ReadLine();
            switch (option)
            {
                case "a":
                    //Trace.WriteLine("Add New Student Information - Opeartion");
                    AddStudentDetails();                    
                    break;
                case "b":
                    //Trace.WriteLine("View Recently Added Student Information - Opeartion");
                    GetRecentlyAddedStudentInfo();                    
                    break;
                case "3":
                    //Trace.WriteLine("View All Student Information - Opeartion");
                    LoadAllStudentInfo();                    
                    break;
                case "d":
                    
                    break;
                default:
                    Console.WriteLine("please choose correct option from the list \n\n");
                    break;

            }


            Console.ReadLine();
        }

        public void AddStudentDetails()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Student stu = new Student();

            Console.WriteLine("Please add student id (must use integer number)");
            stu.studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please add student name (first name only)");
            stu.StudentName = Console.ReadLine();

            //add student info in list
            students.Add(stu);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("student info registered succesfully... \n");

            LoadOperations();
        }

        public void GetRecentlyAddedStudentInfo()
        {
            if (!students.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sorry, please add student info first! \n");
                LoadOperations();
            }
            else
            {
                var student = students[students.Count - 1];
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t Recently added Student Id is {0} and Name is {1}. \n", student.studentId, student.StudentName);

                LoadOperations();
            }
        }

        public void LoadAllStudentInfo()
        {
            if (!students.Any())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sorry, please add student info first! \n");
                LoadOperations();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine("\t Student Id : {0}", students[i].studentId);
                    Console.WriteLine("\t Student Name : {0}", students[i].StudentName);
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");

                LoadOperations();
            }
        }


    }
}
