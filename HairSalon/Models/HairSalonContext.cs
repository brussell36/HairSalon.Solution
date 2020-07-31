using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual Dbset<Stylist> Stylists { get; set; }
    public Dbset<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}