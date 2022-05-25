using eticaretApi.Domain.Entities;
using eticaretApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Persistence.Contexts
{//entitity framework ormsi kullanacağımızdan dolayı
    //dbcontext ten inherit edicez
    public class eticaretApiDbContext : DbContext
    {
        public eticaretApiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //yapılan değişiklikleri yakalmaa DbContexten geliyor.
            var datas = ChangeTracker
                .Entries<BaseEntity>();
            //bundan sonra sürece giren bütün entriyleri yakala demek.
            //entityler üzerinden yapılan değşikliklerin yada yeni eklenen deişikliklerin
            //yakalanmasını sağlayana rpertydir.
            //track edilen verileri yakalayıp elde etmemizi sağlar.
            //update operasyonlarında track edilen verileri yakalammızı sağlar
            foreach (var data in datas)
            {
                //ne kadar data geliyorsa burda yakalıyoz işte
                _ = data.State switch
                {//eğer bu bir ekleme işlemiyse
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    //eğer update işmeiyse
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow
                };

            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
