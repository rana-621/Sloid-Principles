using SOLID.DIP.After;

namespace SOLID.DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var customers = Before.Repository.Customers;
            //foreach (var customer in customers)
            //{
            //    var notificationService = new Before.NotificationService(customer);
            //    notificationService.Notify();
            //}


            var customers = After.Repository.Customers;
            foreach (var customer in customers)
            {
                var messageServices = new List<IMessageService>
                {
                    new After.EmailService { EmailAddress = customer.EmailAddress },
                    new After.SmsService { MobileNo = customer.MobileNo },
                    new After.MailService { Address = customer.Address }
                };
                var notificationService = new After.NotificationService(messageServices);
                notificationService.Notify();
            }
        }
    }
}
