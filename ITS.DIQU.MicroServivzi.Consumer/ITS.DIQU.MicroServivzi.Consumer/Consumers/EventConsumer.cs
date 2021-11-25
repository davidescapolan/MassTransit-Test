using ITS.DIQU.MicroServizi.SharedClass;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.DIQU.MicroServivzi.Consumer.Consumers
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
