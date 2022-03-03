using System;

namespace SalaryCalculator
{
    public class EmployeeService
    {
        private const decimal BASIC_SALARY = 10000000;

        public static decimal CalculateSalary(EmployeeType employeeType, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Years of experience is not valid");
            }

            decimal factor = 0;

            // if (employeeType == EmployeeType.Engineer)
            // {
            //     factor = 1;
            // }
            // else if (employeeType == EmployeeType.SeniorEngineer || employeeType == EmployeeType.Manager)
            // {
            //     // factor = 1.5m;
            //     factor = 2;
            // }
            // else if (employeeType == EmployeeType.SeniorManager)
            // {
            //     factor = 3;
            // }
            // // TODO: if employee is Expert, set factor = 3

            switch (employeeType)
            {
                case EmployeeType.Engineer:
                    factor = 1;
                    break;
                case EmployeeType.SeniorEngineer:
                case EmployeeType.Manager:
                    factor = 2;
                    break;
                case EmployeeType.SeniorManager:
                    factor = 3;
                    break;
                case EmployeeType.Expert:
                    factor = 3;
                    break;
                default:
                    break;
            }

            var salary = BASIC_SALARY * years * factor;

            return salary;
        }
    }
}
