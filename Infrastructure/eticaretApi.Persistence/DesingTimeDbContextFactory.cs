using eticaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Persistence
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<eticaretApiDbContext>
    {
        public eticaretApiDbContext CreateDbContext(string[] args)
        {
            
            //power shell üzeirnd en migration vermen gerekebilir bzaen ondan
            //bunu yapıyoruz.
            DbContextOptionsBuilder<eticaretApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
