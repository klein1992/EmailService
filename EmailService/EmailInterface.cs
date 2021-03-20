using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService
{
    public interface EmailInterface
    {
        Task SendEmail(OrderDetailsDto order);
    }
}
