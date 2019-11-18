namespace QueuePublisher
{
    public class RabbitHostConfiguration
    {
        public string HostName { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VirtualHost { get; set; }
    }

    public class RabbitInfoQueuePublushConfiguration
    {
        public string ExchangeName { get; set; }
        public string RoutingKey { get; set; }
    }

    public class RabbitInfoQueueConfiguration : RabbitInfoQueuePublushConfiguration
    {
        public string ExchangeType { get; set; } = QueuePublisher.ExchangeType.Direct;
        public string QueueName { get; set; }
        public int NumberOfWorkroles { get; set; } = 1;
        public bool CreateDeadLetterQueue { get; set; } = false;
    }

    public class RabbitConfiguration : RabbitInfoQueueConfiguration
    {
        public string HostName { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VirtualHost { get; set; }
    }
}
