namespace SOLID.DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = Before.Repository.Customers;
            foreach (var customer in customers)
            {
                var notificationService = new Before.NotificationService(customer);
                notificationService.Notify();
            }
        }
    }
}
