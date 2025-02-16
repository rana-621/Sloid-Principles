namespace SOLID.DIP.After
{
    internal class NotificationService
    {
        private readonly List<IMessageService> _services;

        //Injection Constructor
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {
            foreach (var service in _services)
            {
                service.Send();
            }
        }

        internal class NotificationService1
        {
            public List<IMessageService> Services { get; private set; }
            public void Notify()
            {
                foreach (var service in Services)
                {
                    service.Send();
                }
            }
            public void SetServices(List<IMessageService> services)
            {
                Services = services;
            }

        }
        internal class NotificationService2
        {
            public void Notify(List<IMessageService> services)
            {
                foreach (var service in services)
                {
                    service.Send();
                }
            }


        }
    }
}
