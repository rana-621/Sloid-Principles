namespace SOLID.DIP.Before
{
    internal class NotificationService
    {
        private readonly Customer customer;
        private readonly EmailService emailService;
        private readonly SmsService smsService;

        public NotificationService(Customer customer)
        {
            emailService = new EmailService
            {
                EmailAddress = customer.EmailAddress
            };
            smsService = new SmsService
            {
                MobileNo = customer.MobileNo
            };


        }
        public void Notify()
        {
            emailService.Send();
            smsService.Send();
        }
    }
}
