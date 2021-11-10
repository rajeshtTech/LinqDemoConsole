using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPracticeConsole
{
    public static class StaticDataRepository
    {
        // *************************** SUPPLIER *******************************************
        static Supplier sup1 = new Supplier { Id = 1, Name = "Amazon" };
        static Supplier sup2 = new Supplier { Id = 2, Name = "Flipkart" };
        static Supplier sup3 = new Supplier { Id = 3, Name = "D Mart" };
        static Supplier sup4 = new Supplier { Id = 4, Name = "Myntra" };
        
        // *************************** PRODUCT *******************************************
        static Product prod1 = new Product { Id = 1, Name = "Chess", Description = "Playing Chess Board", Price = 1000, Supplier = sup1 };
        static Product prod2 = new Product { Id = 2, Name = "TV", Description = "Samsung TV", Price = 5000, Supplier = sup1 };
        static Product prod3 = new Product { Id = 3, Name = "Rice Bag", Description = "Basmati Rice Bag 5 kg", Price = 800, Supplier = sup3 };
        static Product prod4 = new Product { Id = 4, Name = "Shirt", Description = "Raymond Shirt", Price = 2000, Supplier = sup4 };
        static Product prod5 = new Product { Id = 5, Name = "Laptop", Description = "Dell Laptop", Price = 4500, Supplier = sup1 };
        static Product prod6 = new Product { Id = 6, Name = "Trousers", Description = "Calvin Clien Trousers", Price = 2200, Supplier = sup4 };

        // *************************** STUDENT *******************************************
        static Student stud1 = new Student { Id = 1, Name = "Ram", Marks = 400 };
        static Student stud2 = new Student { Id = 2, Name = "Tom", Marks = 200 };
        static Student stud3 = new Student { Id = 3, Name = "Peter", Marks = 200 };
        static Student stud4 = new Student { Id = 4, Name = "Puneet", Marks = 100 };
        static Student stud5 = new Student { Id = 5, Name = "Sachin", Marks = 400 };
        static Student stud6 = new Student { Id = 6, Name = "Hari", Marks = 400 };
        static Student stud7 = new Student { Id = 7, Name = "Neha", Marks = 200 };

        // *************************** Employee *******************************************
        // Developer
        static Employee emp1 = new Employee { Id = 1, Name = "Ramesh", DeptId = 101, Gender = 1};
        static Employee emp2 = new Employee { Id = 2, Name = "Peter", DeptId = 101, Gender = 1 };
        static Employee emp3 = new Employee { Id = 3, Name = "Rachna", DeptId = 101, Gender = 2 };

        // Admin
        static Employee emp4 = new Employee { Id = 4, Name = "Mandar", DeptId = 102, Gender = 1 };
        static Employee emp5 = new Employee { Id = 5, Name = "Pooja", DeptId = 102, Gender = 2};
        
        // Security
        static Employee emp6 = new Employee { Id = 6, Name = "Satish", DeptId = 103, Gender = 1 };
        static Employee emp7 = new Employee { Id = 7, Name = "Ali", DeptId = 103, Gender = 1 };

        // Accounts
        static Employee emp8 = new Employee { Id = 8, Name = "Kamlesh", DeptId = 104, Gender = 1 };

        // No Department Assign yet
        static Employee emp9 = new Employee { Id = 9, Name = "Sneha", Gender = 2};

        // *************************** Department *******************************************
        static Deapartment dept1 = new Deapartment { Id = 101, Name = "Development"};
        static Deapartment dept2 = new Deapartment { Id = 102, Name = "Admin"};
        static Deapartment dept3 = new Deapartment { Id = 103, Name = "Security"};
        static Deapartment dept4 = new Deapartment { Id = 104, Name = "Accounts" };
        static Deapartment dept5 = new Deapartment { Id = 105, Name = "HR" };



        public static List<Supplier> Suppliers = new List<Supplier> { sup1, sup2, sup3, sup4 };
        public static List<Product> Products = new List<Product> { prod1, prod2, prod3, prod4, prod5, prod6 };

        public static List<Student> Students = new List<Student> { stud1, stud2, stud3, stud4, stud5, stud6, stud7 };

        public static List<Employee> Employees = new List<Employee> { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9 };
        public static List<Deapartment> Departments = new List<Deapartment> { dept1, dept2, dept3, dept4, dept5};
    }
}
