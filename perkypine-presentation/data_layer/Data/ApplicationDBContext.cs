using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer.Data
{
    public class ApplicationDBContext : DbContext
    {
        //public virtual DbSet<GameIdea> GameIdeas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //   .UseMySQL("server=127.0.0.1;port=3306;user=root;password=root;database=PerkyPineDB")
        //    .UseLoggerFactory(LoggerFactory.Create(b => b
        //                  .AddConsole()
        //                  .AddFilter(level => level >= LogLevel.Information)))
        //    .EnableSensitiveDataLogging()
        //    .EnableDetailedErrors();
        //}
    }
}