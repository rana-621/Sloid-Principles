namespace SOLID.ISP.After
{
    abstract class Employee
    {
        public string EmployeeNO { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        protected abstract decimal CalculateNetSalary();
        public abstract string PrintSalarySlip();
    }
}
