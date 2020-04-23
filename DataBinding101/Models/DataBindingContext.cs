using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DataBinding101.Models
{
    public class DataBindingContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bubba.db");
            base.OnConfiguring(optionsBuilder);
        }
    }

    // begin data classes
    public class Character
    {
        public int CharacterId { get; set; }    // primary key by convention

        public string Name { get; set; }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Charisma { get; set; }

        // navigation properties
        public virtual List<Equipment> Equipment { get; set; }

    }

    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Description { get; set; }

        // navigation properties
        public virtual Character Owner { get; set; }
    }

}
