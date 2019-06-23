using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Douana.EntityFrameworkCore
{
    public static class DouanaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DouanaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DouanaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
