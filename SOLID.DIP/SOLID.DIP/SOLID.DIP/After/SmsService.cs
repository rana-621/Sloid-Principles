namespace SOLID.DIP.After
{
    internal class SmsService : IMessageService
    {
        public string MobileNo { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sms message is sent to {MobileNo}");
        }
    }
}
