namespace SOLID.ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Before.Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                System.Console.WriteLine(employee.PrintSalarySlip());
                Console.WriteLine();
            }
        }
    }
}
