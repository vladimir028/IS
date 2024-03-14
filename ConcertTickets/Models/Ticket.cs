using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }    
        public Guid ConcertId {  get; set; }
        public Concert ?Concert { get; set; }
        public ConcertUser ?ConcertUser { get; set; }
    }
}
