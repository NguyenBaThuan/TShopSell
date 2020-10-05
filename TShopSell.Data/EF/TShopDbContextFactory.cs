using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TShopSell.Data.EF
{
    public class TShopDbContextFactory : IDesignTimeDbContextFactory<TShopDbContext>
    {
        public TShopDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TShopSellDb");

            var optionsBuilder = new DbContextOptionsBuilder<TShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TShopDbContext(optionsBuilder.Options);
        }
    }
}
