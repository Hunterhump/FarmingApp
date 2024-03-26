using FarmFamAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass>options) : base(options)
        { }
        public DbSet<ClimatePrediction> ClimatePredictions { get; set;}
    }
}
