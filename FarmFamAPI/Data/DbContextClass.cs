using FarmFamAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass>options) : base(options)
        { }
        public DbSet<ClimatePrediction> ClimatePredictions { get; set;}
        public DbSet<Crop> Crop { get; set;}
        public DbSet<FarmingPlan> FarmingPlan { get; set;}
        public DbSet<CropCompatibility> CropCompatibility { get; set;}
     }
}
