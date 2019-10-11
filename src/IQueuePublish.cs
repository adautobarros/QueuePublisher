namespace QueuePublisher
{
    public interface IQueuePublish
    {
        void Publish<T>(T entidade, string configPublishSectionRabbitMQ);
        void Publish<T>(T entidade, RabbitInfoQueuePublushConfiguration info);
        void Publish<T>(T Item, string exchangeName = "", string exchangeType = ExchangeType.Direct, string routingKey = "", string queueName = "");
    }

    public static class ExchangeType
    {
        public const string Direct = "direct";
        public const string Fanout = "fanout";
        public const string Headers = "headers";
        public const string Topic = "topic";
    }  
}
