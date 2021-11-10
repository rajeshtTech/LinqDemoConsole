using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static LinqPracticeConsole.Shared;
using static LinqPracticeConsole.Program;
using System.Linq;

namespace LinqPracticeConsole
{
    public class EmployeeBO
    {
        static List<Employee> Employees = StaticDataRepository.Employees;
        static List<Deapartment> Departments = StaticDataRepository.Departments;

        private static void EmployeeFunctionSelection(char functKey)
        {
            switch (functKey)
            {
                case '1':
                    GetAllEmployees();
                    break;
                case '2':
                    GetAllDepartments();
                    break;
                case '3':
                    EmployeeWithDepartment();
                    break;
                case '4':
                    DepartmentWiseEmployee();
                    break;
                case '5':
                    EmployeeLeftJoinDepartment();
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
            WriteLine("1. Get All Employees");
            WriteLine("2. Get All Departments");
            WriteLine("3. Employee and its Department");
            WriteLine("4. Department Group wise Employee (Department Group Join Employee)");
            WriteLine("5. Employee left join Deparment");
            //WriteLine("5. Get Last Student with Highest Mark");
            //WriteLine("6. Get Second Highest Mark Students");
            //WriteLine("7. Get First Student with Second Highest Marks");
            //WriteLine("8. Get Second Last Student with Second Highest Marks");
            WriteLine("9. Back to Main Menu");
            WriteLine("   Press Escape Key to End");
        }

        public static void EmployeeFunction()
        {
            DisplayAllFunctions();
            SelectFunction(EmployeeFunctionSelection);           
        }

        public static void GetAllEmployees()
        {
            WriteLine("All the Employees");
            foreach(var emp in Employees)
                WriteLine(nameof(emp.Name) +": " + emp.Name );
        }

        public static void GetAllDepartments()
        {
            WriteLine("All the Departments");
            foreach (var dept in Departments)
                WriteLine(nameof(dept.Name) + ": " + dept.Name);
        }

        private static void EmployeeWithDepartment()
        {
            WriteLine("Employee with its Department");
            var empWithDeptList = Employees.Join(Departments, 
                                                 e => e.DeptId, 
                                                 d => d.Id,
                                                (e, d) => new { EmpName = e.Name, DeptName = d.Name }
                                                );
            foreach (var empWithDept in empWithDeptList)
                WriteLine($"Employee: {empWithDept.EmpName}; Department: {empWithDept.DeptName}");
        }

        private static void DepartmentWiseEmployee()
        {
            WriteLine("Department Group wise Employee (Department Group Join Employee)");
            var deptGroupWiseEmployee = Departments.GroupJoin(Employees,
                                                              d => d.Id,
                                                              e => e.DeptId,
                                                              (d, e) => new { DeptName = d.Name, EmpList = e}
                                                             );

            foreach (var deptWithEmpList in deptGroupWiseEmployee)
            {
                WriteLine($"Department Name: {deptWithEmpList.DeptName}");
                foreach (var emp in deptWithEmpList.EmpList)
                    WriteLine($"Employee Name: {emp.Name}");
                WriteLine("--------------------------------------------");
            }
        }

        private static void EmployeeLeftJoinDepartment()
        {
            WriteLine("Employee left join Deparment");
            var empWithDepartment = Employees.GroupJoin(Departments,
                                                        e => e.DeptId,
                                                        d => d.Id,
                                                        (e, d) => new { EmpName = e.Name, DepartList = d })
                                              .SelectMany(ed => ed.DepartList.DefaultIfEmpty(), (ed, d) => new { EmpName = ed.EmpName, DeptName = d?.Name });

            foreach (var empWiseDept in empWithDepartment)
                WriteLine($"Employee: {empWiseDept.EmpName}; Department: {empWiseDept.DeptName}");
        }
    }
}
