namespace SOLID.DIP.Before
{
    internal class SmsService
    {
        public string MobileNo { get; set; }
        public void Send()
        {
            Console.WriteLine($"SMS sent to the customer {MobileNo}");
        }
    }
}
