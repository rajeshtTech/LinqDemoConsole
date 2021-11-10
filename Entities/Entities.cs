using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPracticeConsole
{
    public class Supplier
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        //public List<ProductShipment> ProductShipments { get; set; }
    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }        
        public byte Gender { get; set; }
    }

    public class Deapartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
