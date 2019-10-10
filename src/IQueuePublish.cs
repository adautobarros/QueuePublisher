namespace QueuePublisher
{
    public interface IQueuePublish
    {
        void Publish<T>(T Item, string exchangeName = "", string exchangeType = ExchangeType.Direct, string routingKey = "", string queueName = "");
    }

    public static class ExchangeType
    {
        public const string Direct = "direct";
        public const string Fanout = "fanout";
        public const string Headers = "headers";
        public const string Topic = "topic";
    }

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
    public class RabbitInfoQueueConfiguration
    {
        public string ExchangeName { get; set; }
        public string ExchangeType { get; set; }
        public string RoutingKey { get; set; }
        public string QueueName { get; set; }
        public int NumberOfWorkroles { get; set; }
    }
}
