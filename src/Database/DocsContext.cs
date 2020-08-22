using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BlazorDocs.Database
{
    public class DocsContext : DbContext
    {
        public static readonly ILoggerFactory ConsoleLogger =
            LoggerFactory.Create(builder => { builder.AddConsole(); });

        public DocsContext(DbContextOptions<DocsContext> options)
            : base(options)
        { }

        public DbSet<Doc> Docs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(ConsoleLogger);
        }
    }
}