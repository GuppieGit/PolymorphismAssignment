using System;

namespace InterfaceExample
{
    // Define the IQuittable interface
    public interface IQuittable
    {
        // Method signature for Quit, which any implementing class must define
        void Quit();
    }

    // Employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementation of the Quit method from IQuittable
        public void Quit()
        {
            // Display a message when the employee quits
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Polymorphism: Create an IQuittable reference and assign it an Employee object
            IQuittable quittableEmployee = employee1;

            // Call the Quit method on the IQuittable object, which refers to the employee1 object
            quittableEmployee.Quit();

            // Pause to see the output
            Console.ReadLine();
        }
    }
}
