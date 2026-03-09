namespace ConsoleAppTraditional.SOLID
{
    // Interfață pentru servicii de mesaje
    interface IMessageService
    {
        void Send(string message);
    }


    // Implementarea concretă a serviciului de mesaje
    class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    class FaceTimeService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }


    class NotificationService
    {
        private IMessageService _messageService;


        public NotificationService(IMessageService messageService)
        {
            _messageService = messageService;
        }


        public void Notify(string message)
        {
            _messageService.Send(message);
        }
    }

}
