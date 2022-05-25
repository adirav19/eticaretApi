using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eticaretApi.Persistence.Contexts;
using eticaretApi.Application.Repositories;
using eticaretApi.Persistence.Repositories;

namespace eticaretApi.Persistence
{
    public static class ServiceRegistration
    {//static olması sebebi ekstenşın fonsksiyon tanımlayacağız
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();
            //sencen ıproduct service istenirse product serviceyi döndür diyoruz.
            services.AddDbContext<eticaretApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString) );

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
                     
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
                     
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        }
    }
}
