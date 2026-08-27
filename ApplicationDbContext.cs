using DotnetWebApiUnitTesting.Helpers;
using DotnetWebApiUnitTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetWebApiUnitTesting
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            // default constructor
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseMySql(
                    connectionString: GlobalAttributesHelper.mySqlConfiguration.connectionString,
                    serverVersion: GlobalAttributesHelper.mySqlConfiguration.serverVersion);
            }
        }


        public virtual DbSet<PartnerTransactionModel> PartnerTransaction { get; set; }
    }
}
