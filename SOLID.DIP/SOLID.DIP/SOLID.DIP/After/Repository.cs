namespace SOLID.DIP.After
{
    internal static class Repository
    {

        public static List<Customer> Customers =>
            new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Name = "John",
                    MobileNo = "1234567890",
                    EmailAddress = "john@example.com",
                    Address = "123, Baker Street, London"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Smith",
                    MobileNo = "1234567890",
                    EmailAddress = "smith@example.com",
                    Address = "123, Baker Street, London"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Paul",
                    MobileNo = "1234567890",
                    EmailAddress = "Paul@example.com",
                    Address = "123, Baker Street, London"
                },

            };
    }
}
