using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"The sum is: \n" +
                $"{numbers.Sum()}");
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine($"The average is: \n" +
                $"{numbers.Average()}");
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("The ascending order is:");
            numbers.OrderBy(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("The descending order is:");
            numbers.OrderByDescending(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("The numbers greater than 6 are:");
            numbers.Where(num => num > 6).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("The first 4 numbers in descending order are:");
            var print4 = numbers.OrderByDescending(num => num);
            foreach (var num in print4)
            {
                if (num > 5)
                {
                    Console.WriteLine(num);
                } 
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("The descending order, with my age replacing the number at index 4, is:");
            numbers.SetValue(34, 4);
            numbers.OrderByDescending(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("The employees whose first names start with C or S, in ascending order by first name, are:");
            employees.Where(employee => employee.FirstName.StartsWith("C") || employee.FirstName.StartsWith("S"))
                .OrderBy(employee => employee.FirstName).ToList().ForEach(employee => Console.WriteLine(employee.FullName));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("The employees over the age 26, ordered by age and then by first name, are:");
            employees.Where(employee => employee.Age > 26)
                .OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName)
                .ToList().ForEach(employee => Console.WriteLine($"{employee.FullName}, {employee.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("The sum and average, respectively, of the employees' years of experience is:");
            int sumOfYOE = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Sum(employee => employee.YearsOfExperience);
            double avgOfYOE = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Average(employee => employee.YearsOfExperience);
            Console.WriteLine($"{sumOfYOE}, {avgOfYOE}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("The updated employee list is:");
            employees.Append(new Employee("Kassandra", "Johnson", 34, 1)).ToList().ForEach(employee => Console.WriteLine(employee.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
