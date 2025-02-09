namespace CATightlyVsLooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService(new EmailService());
            notificationService.Notify();
            Console.ReadKey();
        }
    }



    interface INotificationMode
    {
        void Send();
    }


    class EmailService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("email Notification");
        }
    }

    class SmsService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("sms Notification");
        }
    }

    class WeirdService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("blabla NOtification");
        }
    }
    #region Befor using interface and enhance the solution using loosely coupled
    //class EmailNotification()
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("email NOtification");
    //    }
    //}
    //class SMSNotification()
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("sms NOtification");
    //    }
    //}
    #endregion
    class NotificationService
    {

        #region Before using interface and enhance the solution using loosely coupled
        //private readonly EmailNotification _emailNotification;
        //private readonly SMSNotification _smsNotification;

        //public NotificationService(EmailNotification emailNotification, SMSNotification smsNotification)
        //{
        //     _emailNotification = emailNotification;
        //    _smsNotification = smsNotification;
        //}
        #endregion

        private readonly INotificationMode _notificationMode;


        public NotificationService(INotificationMode notificationMode)
        {
            _notificationMode = notificationMode;
        }

        public void Notify()
        {
            _notificationMode.Send();
        }
    }
}