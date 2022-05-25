using eticaretApi.Application.Repositories;
using eticaretApi.Domain.Entities;
using eticaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(eticaretApiDbContext context) : base(context)
        {
        }
    }
}
