using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Mounika_EmployeeClassLibrary
{
    
        public class SalaryCalculation : Employee
        {

            public double HRA { get; set; }
            public double TA { get; set; }
            public double DA { get; set; }
            public double Tax { get; set; }
            public double NetSalary { get; set; }
            public override void DisplayEmployeeDetails()
            {
                Console.WriteLine("\n****** Employee details are...*******");
                Console.WriteLine("Employee Id: " + EmployeeId);
                Console.WriteLine("Employee Name: " + EmployeeName);
                Console.WriteLine("Employee Salary: " + EmployeeSalary);
            }


            public override void TaxCalculation()
            {

                if (EmployeeSalary < 10000)
                {
                    HRA = EmployeeSalary * 0.12;
                    TA = EmployeeSalary * 0.1;
                    DA = EmployeeSalary * 0.15;
                    Tax = EmployeeSalary * 0.1;
                }
                else
                {
                    HRA = EmployeeSalary * 0.5;
                    TA = EmployeeSalary * 0.12;
                    DA = EmployeeSalary * 0.3;
                    Tax = EmployeeSalary * 0.25;
                }
                NetSalary = EmployeeSalary + HRA + TA + DA - Tax;

            }

            public override void DisplaySalaryDetails()
            {
                Console.WriteLine("\nSalary Details are...:");
                Console.WriteLine("HRA: " + HRA);
                Console.WriteLine("TA: " + TA);
                Console.WriteLine("DA: " + DA);
                Console.WriteLine("Tax: " + Tax);
                Console.WriteLine("\nAnd Net Salary:: " + NetSalary);
            }
        }
    }

