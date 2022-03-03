using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);
            Console.WriteLine(string.Format("Expert's Salary: {0}", expertSalary));

            Console.ReadLine();
        }
    }
}
