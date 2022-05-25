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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository

    {
        public CustomerWriteRepository(eticaretApiDbContext context) : base(context)
        {
        }
    }
}
