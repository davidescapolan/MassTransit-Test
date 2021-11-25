using ITS.DIQU.MicroServizi.SharedClass;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace ITS.DIQU.MicroServizi.Sender.Controllers
{
    [Route("message")]
    [ApiController]
    public class SenderController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        public SenderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        [HttpPost]
        public async Task<ActionResult> SendCommand()
        {
            await _publishEndpoint.Publish(
                    new NewMessage()
                    {
                        Now= DateTime.Now
                    }
                );
            return StatusCode(204);
        }
    }
}
