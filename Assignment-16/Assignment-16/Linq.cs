using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    class Linq
    {
        public static void Main(string[] args)
        {

           Console.WriteLine("Demo of Linq Concepts");

            IList ar = new ArrayList();
            Console.WriteLine("Enter your name");
            ar.Add(Console.ReadLine());
            Console.WriteLine("Enter your emailId");
            ar.Add(Console.ReadLine());
            Console.WriteLine("Enter your age");
            ar.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter your Designation");
            ar.Add(Console.ReadLine());
            Console.WriteLine("Enter Your Phone Number");
            ar.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Your empId");
            ar.Add(Convert.ToInt32(Console.ReadLine()));

            var elements = from i in ar.OfType<Object>() select i;

            foreach (var i in elements)
            {
                Console.WriteLine(i);
            }

            IList<Employee> emp = new List<Employee>() {
                new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 33} ,
                new Employee() { EmployeeID = 2, EmployeeName = "Mark",  Age = 54 } ,
                new Employee() { EmployeeID = 3, EmployeeName = "Mark", Age = 21 },
                new Employee() { EmployeeID = 4, EmployeeName = "Ben",  Age = 25 } ,
                new Employee() { EmployeeID = 5, EmployeeName = "Rocky" , Age = 20} ,
                new Employee() { EmployeeID = 6, EmployeeName = "Ronnie" , Age = 19}
            };

            Console.WriteLine("All employees in Employee");

            var ele = from i in emp select i;

            foreach (var i in ele)
            {
                Console.WriteLine(i); // Will now use the overridden ToString()
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            //var ele = from i in emp select new { i.EmployeeID, i.EmployeeName, i.Age };

            /*foreach (var i in ele)
            {
                Console.WriteLine($"ID: {i.EmployeeID}, Name: {i.EmployeeName}, Age: {i.Age}");
            }*/

            Console.WriteLine("All employees in Employee whose age is above 30 but below 70");
            var filteredResult = from e in emp
                                 where e.Age > 30 && e.Age < 70
                                 select e.EmployeeName;


            foreach (var i in filteredResult)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            Console.WriteLine("All employees in Employee names in Ascending order");
            var orderByResult = from e in emp
                                orderby e.EmployeeName
                                select e;

            foreach (var i in orderByResult)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();

            Console.WriteLine("All employees in Employee names in Descending order");
            var orderByDescendingResult = from e in emp
                                          orderby e.EmployeeName descending
                                          select e;

            foreach (var i in orderByDescendingResult)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();


            Console.WriteLine("All employees in Employee after names Ascending then Age Ascending");
            var thenByResult = emp.OrderBy(e => e.EmployeeName).ThenBy(e => e.Age);

            foreach (var i in thenByResult)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"ID: {EmployeeID}, Name: {EmployeeName}, Age: {Age}";
        }



    }


}

