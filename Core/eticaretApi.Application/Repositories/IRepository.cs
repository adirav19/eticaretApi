using eticaretApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {//dbset class istedği için t yi class olarak aayarladık.
        //entityler belli değilken bile bu işlem yapılabilir
        //generic olması için bunu yapıyoruz.
        DbSet<T> Table { get; }
    }
}
