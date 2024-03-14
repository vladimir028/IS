using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConcertTickets.Models;

namespace ConcertTickets.Data
{
    public class ApplicationDbContext : IdentityDbContext <ConcertUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ConcertTickets.Models.Concert> Concert { get; set; } = default!;
        public DbSet<ConcertTickets.Models.Ticket> Ticket { get; set; } = default!;
    }
}
