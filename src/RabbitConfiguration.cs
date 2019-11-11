﻿namespace QueuePublisher
{
    public class RabbitConfiguration
    {
        public string HostName { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ExchangeName { get; set; }
        public string VirtualHost { get; set; }
        public string ExchangeType { get; set; }
        public string RoutingKey { get; set; }
        public string QueueName { get; set; }
        public int NumberOfWorkroles { get; set; }
    }
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
        public string ExchangeType { get; set; }
        public string QueueName { get; set; }
        public int NumberOfWorkroles { get; set; }
    }
}
