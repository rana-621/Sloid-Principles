namespace SOLID.ISP.After
{
    static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Staff
                {
                    EmployeeNO = "STF001",
                    Name = "John Doe",
                    Salary = 5000
                },
                new Consultant
                {
                    EmployeeNO = "CON001",
                    Name = "Jane Doe",
                    Salary = 5000
                },
                new Daylabourer
                {
                    EmployeeNO = "DL001",
                    Name = "Sam Doe",
                    Salary = 5000
                },

                };
        }
    }
}
