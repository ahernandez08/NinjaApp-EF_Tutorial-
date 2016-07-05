using System.Collections.Generic;
using System.Data.Entity;
using NinjaDomain.Clasess;

namespace NinjaDomain.DataModel
{
    public class NinjaContext: DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
