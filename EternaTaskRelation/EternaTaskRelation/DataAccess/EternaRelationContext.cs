using EternaTaskRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaTaskRelation.DataAccess
{
    public class EternaRelationContext:DbContext
    {
        public EternaRelationContext(DbContextOptions<EternaRelationContext> options):base(options)
        {
            
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

    }
}
