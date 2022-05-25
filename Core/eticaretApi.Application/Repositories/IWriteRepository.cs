using eticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {// t nin class olmasının açıklaması ı repositoryde
        //eklemee operasyonları
        Task<bool> AddAsync(T model);
        //gelen model neyse onu eklicek 1 tane ekle
        Task<bool> AddRangeAsync(List<T> model);
        //GELEEn birden fazlaysa kolaksiyonsa bu çalışır (üstteki) 
        
        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
