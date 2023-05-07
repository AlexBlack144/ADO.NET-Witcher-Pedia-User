using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsWitcher.Model
{
    public partial class WitcherModel : DbContext
    {
        public WitcherModel()
            : base("name=WitcherModel2")
        {
        }

        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>()
                .HasMany(e => e.Characters)
                .WithOptional(e => e.Chapter)
                .HasForeignKey(e => e.Chapter_Id);
        }
    }
}
