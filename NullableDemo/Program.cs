using System;

namespace NullableDemo
{
    public class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PayRate { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                FirstName = "John"
            };

            var namelength = employee.FirstName.Length + employee.LastName?.Length;
            Console.WriteLine($"The employee is called {employee.FirstName} { employee.LastName}");
        }
            //Console.WriteLine("Hello World!");
        
    }
}
