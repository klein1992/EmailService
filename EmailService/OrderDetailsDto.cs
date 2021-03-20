using System;

namespace EmailService
{
    public class OrderDetailsDto
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string email { get; set; }

        public DateTime pickupTime { get; set; }
    }
}
