﻿using eticaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Application.Repositories
{
    public interface IOrderWriteRepository:IWriteRepository<Order>
    {
    }
}
