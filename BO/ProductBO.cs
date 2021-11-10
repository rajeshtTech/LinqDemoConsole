using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static LinqPracticeConsole.Shared;
using static LinqPracticeConsole.Program;
using System.Linq;

namespace LinqPracticeConsole
{
    public class ProductBO
    {
        static List<Supplier> Suppliers = StaticDataRepository.Suppliers;
        static List<Product> Products = StaticDataRepository.Products;

        private static void ProductFunctionSelection(char functKey)
        {
            switch (functKey)
            {
                case '1':
                    GetAllProducts();
                    break;
                case '2':
                    GetAllSuppliers();
                    break;
                case '3':
                    ProductsGroupBySupplierName();
                    break;
                case '4':
                    ProductsGroupBySupplierObject();
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
            WriteLine("1. Get All Products");
            WriteLine("2. Get All Suppliers");
            WriteLine("3. Products Group By Supplier Name -- Key: Supplier Name, Value: Product Name List");
            WriteLine("4. Products Group By Supplier Object -- Key: Supplier Object, Value: Product Object List");
        
            WriteLine("9. Back to Main Menu");
            WriteLine("   Press Escape Key to End");
        }

        public static void ProductFunction()
        {
            DisplayAllFunctions();
            SelectFunction(ProductFunctionSelection);
        }

        public static void GetAllSuppliers()
        {
            WriteLine("All Suppliers");
            foreach (var supplier in Suppliers)
                WriteLine(nameof(supplier.Id) +": "+ supplier.Id +", "+ nameof(supplier.Name) + ": " + supplier.Name);
        }

        public static void GetAllProducts()
        {
            WriteLine("All Products");
            foreach (var product in Products)
                WriteLine(nameof(product.Id) + ": " + product.Id + ", " + nameof(product.Name) + ": " + product.Name);
        }

        public static void ProductsGroupBySupplierName()
        {
            WriteLine("Products Group By Supplier Name -- Key: Supplier Name, Value: Product Name List");
            WriteLine("********************************************");
            var prodBySupplier =  Products.GroupBy(s => s.Supplier.Name);
            
            foreach (var suppGroup in prodBySupplier)
            {
                WriteLine("Supplier: " + suppGroup.Key);
                foreach (var prod in suppGroup)  
                    WriteLine("Product: " + prod.Name);
                WriteLine("********************************************");
            }
        }

        public static void ProductsGroupBySupplierObject()
        {
            WriteLine("Products Group By Supplier Object -- Key: Supplier Object, Value: Product Object List");
            WriteLine("********************************************");
            var prodBySupplier = Products.GroupBy(s => s.Supplier);

            foreach (var suppGroup in prodBySupplier)
            {
                WriteLine("Supplier => Name:" + suppGroup.Key.Name);
                foreach (var prod in suppGroup)
                    WriteLine("Product: " + prod.Name);
                WriteLine("********************************************");
            }
        }


    }
}
