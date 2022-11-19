namespace Test3_Mounika_EmployeeClassLibrary
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }

        public abstract void DisplayEmployeeDetails();

        public abstract void TaxCalculation();
        public abstract void DisplaySalaryDetails();


    }
}