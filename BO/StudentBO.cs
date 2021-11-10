using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static LinqPracticeConsole.Shared;
using static LinqPracticeConsole.Program;
using System.Linq;

namespace LinqPracticeConsole
{
    public class StudentBO
    {
        static List<Student> Students = StaticDataRepository.Students;

        private static void StudentFunctionSelection(char functKey)
        {
            switch (functKey)
            {
                case '1':
                    GetAllStudents();
                    break;
                case '2':
                    GetHigheshtMarkStudent();
                    break;
                case '3':
                    GetFirstHighestMarkStudent();
                    break;
                case '4':
                    GetSecondHighestMarkStudent();
                    break;
                case '5':
                    GetLastStudentWithHighestMark();
                    break;
                case '6':
                    GetSecondHighestMarkStudents();
                    break;
                case '7':
                    GetFirstStudentWithSecondHighestMarks();
                    break;
                case '8':
                    GetSecondLastStudentWithSecondHighestMarks();
                    break;
                case '9':
                    DisplayAndSelect();
                    break;
            }
            WriteLine("\n\n");
            DisplayAllFunctions();
        }

        private static void DisplayAllFunctions()
        {
            WriteLine("Press Number to Select Function");
            WriteLine("1. Get All Students");
            WriteLine("2. Get Highesh Mark Students");
            WriteLine("3. Get First Student with Highest Mark");
            WriteLine("4. Get Second Student with Highest Mark");
            WriteLine("5. Get Last Student with Highest Mark");
            WriteLine("6. Get Second Highest Mark Students");
            WriteLine("7. Get First Student with Second Highest Marks");
            WriteLine("8. Get Second Last Student with Second Highest Marks");

            WriteLine("9. Back to Main Menu");
            WriteLine("   Press Escape Key to End");
        }

        private static IEnumerable<Student> Get_N_HighestMarkStudentList(int skipOrder = 0)
        {
            var maxMarks = Students.Select(s => s.Marks).Distinct().OrderByDescending(s => s).Skip(skipOrder).FirstOrDefault();
            return Students.Where(s => s.Marks == maxMarks);
        }

        public static void StudentFunction()
        {
            DisplayAllFunctions();
            SelectFunction(StudentFunctionSelection);           
        }

        public static void GetAllStudents()
        {
            WriteLine("All students arranged based on Marks");
            foreach (var stud in Students.OrderByDescending(s => s.Marks).ThenBy(s => s.Id))
                WriteLine(" " + nameof(stud.Name) + " : " + stud.Name + " and " + nameof(stud.Marks) + " : " + stud.Marks);
        }
        public static void GetHigheshtMarkStudent()
        {
            var studList = Get_N_HighestMarkStudentList();

            WriteLine("All students with Max Marks");
            foreach (var stud in studList)
                WriteLine(" " + nameof(stud.Name) + " : " + stud.Name + " and " + nameof(stud.Marks) + " : " + stud.Marks);
        }

        public static void GetFirstHighestMarkStudent()
        {
            var studList = Get_N_HighestMarkStudentList();

            var highMarkStud = studList.First();
            WriteLine("First students with Max Marks");
            WriteLine(" " + nameof(highMarkStud.Name) + " : " + highMarkStud.Name + " and " + nameof(highMarkStud.Marks) + " : " + highMarkStud.Marks);
        }

        public static void GetSecondHighestMarkStudent()
        {
            var studList = Get_N_HighestMarkStudentList();

            var secondHighestMarkStudent = studList.Skip(1).FirstOrDefault();
            WriteLine("Second highest mark student");
            WriteLine(" " + nameof(secondHighestMarkStudent.Name) + " : " + secondHighestMarkStudent.Name + " and " + nameof(secondHighestMarkStudent.Marks) + " : " + secondHighestMarkStudent.Marks);
        }
        private static void GetLastStudentWithHighestMark()
        {
            var studList = Get_N_HighestMarkStudentList();

            var lastHighestMarkStudent = studList.Reverse().FirstOrDefault();
            WriteLine("Last highest mark student");
            WriteLine(" " + nameof(lastHighestMarkStudent.Name) + " : " + lastHighestMarkStudent.Name + " and " + nameof(lastHighestMarkStudent.Marks) + " : " + lastHighestMarkStudent.Marks);
        }

        private static void GetSecondHighestMarkStudents()
        {
            var studListSecondHighestMarks = Get_N_HighestMarkStudentList(1);

            WriteLine("All students with Second Highest Marks");
            foreach (var stud in studListSecondHighestMarks)
                WriteLine(" " + nameof(stud.Name) + " : " + stud.Name + " and " + nameof(stud.Marks) + " : " + stud.Marks);
        }

        public static void GetFirstStudentWithSecondHighestMarks()
        {
            var studListSecondHighestMarks = Get_N_HighestMarkStudentList(1);

            WriteLine("First Student with Second Highest Marks");
            var firstStudent = studListSecondHighestMarks.OrderBy(s => s.Id).FirstOrDefault();

            WriteLine(" " + nameof(firstStudent.Name) + " : " + firstStudent.Name + " and " + nameof(firstStudent.Marks) + " : " + firstStudent.Marks);
        }

        public static void GetSecondLastStudentWithSecondHighestMarks()
        {
            var studListSecondHighestMarks = Get_N_HighestMarkStudentList(1);

            WriteLine("Second Last Student with Second Highest Marks");
            var secondLastStudent = studListSecondHighestMarks.OrderByDescending(s => s.Id).Skip(1).FirstOrDefault();

            WriteLine(" " + nameof(secondLastStudent.Name) + " : " + secondLastStudent.Name + " and " + nameof(secondLastStudent.Marks) + " : " + secondLastStudent.Marks);
        }

    }
}
