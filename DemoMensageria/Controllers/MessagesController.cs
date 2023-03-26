using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;

namespace DemoMensageria.Controllers
{
    [Route("api/messages")]
    public class MessagesController : ControllerBase
    {
        private const string QUEUE_NAME = "messages";
        private readonly ConnectionFactory _factory;

        public MessagesController()
        {
            _factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }
    }
}
