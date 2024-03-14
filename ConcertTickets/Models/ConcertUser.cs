using Microsoft.AspNetCore.Identity;

namespace ConcertTickets.Models
{
    public class ConcertUser : IdentityUser
    {
        public String ?FirstName { get; set; }
        public String ?LastName { get; set; }
        public String ?Address { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }

    }
}
