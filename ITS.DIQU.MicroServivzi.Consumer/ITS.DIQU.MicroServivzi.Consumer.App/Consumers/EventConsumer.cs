using ITS.DIQU.MicroServizi.SharedClass;
using MassTransit;

namespace ITS.DIQU.MicroServivzi.Consumer.App.Consumers
{
    public class EventConsumer : IConsumer<NewMessage>
    {
        public Task Consume(ConsumeContext<NewMessage> context)
        {
            Console.WriteLine($"{context.Message.Now}");
            return Task.CompletedTask;
        }
    }
}
