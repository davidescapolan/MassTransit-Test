using ITS.DIQU.MicroServivzi.Consumer;
using ITS.DIQU.MicroServivzi.Consumer.Consumers;
using MassTransit;

Microsoft.Extensions.Hosting.IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        
        services.AddHostedService<Worker>();
        
    })
    .Build();
var builder = 
buider.Services.AddMassTransit(massTransitConfigurator =>
{
    massTransitConfigurator.UsingRabbitMq(configure: (contect, rbCgf) =>
    {
        rbCgf.Host("localhost", "/", h =>
        {
            h.Username("admin");
            h.Password("password");
        });

        rbCgf.ReceiveEndpoint("new-event-queue", e =>
        {
            e.Consumer(() => new EventConsumer());
        });
    });
});
services.AddMassTransitHostedService();

await host.RunAsync();
