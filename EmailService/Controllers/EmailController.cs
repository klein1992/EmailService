using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace EmailService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly EmailInterface emailService;
        public EmailController(EmailInterface emailService) => this.emailService = emailService;

        [HttpPost]
        public async Task<IActionResult> SendEmail(OrderDetailsDto order)
        {
            await emailService.SendEmail(order);
            return Ok();
        }


    }
}
