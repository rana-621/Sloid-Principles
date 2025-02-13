namespace SOLID.DIP.Before
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"Email sent to the customer {EmailAddress}");
        }
    }
}
