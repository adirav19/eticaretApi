using eticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : BaseEntity
    {// t nin class olmasının açıklaması ı repositoryde
        IQueryable<T> GetAll(bool tracking = true);
        //tracking mekanızması veri üzeirnde değişim yapılmayacaksa gereksizdir. o yüzden traacking i get içeren bütün fonksiyonlarda kapatacağız ve maliyetinden kurtulmuş olacağız.
        //tracking mekanizması ef core un veri üzerinde değişikik varmı yokmu öğrenmesini sağlayan mekanizmadır.
        //IQUERYABLE sorgu üzerinde çalışmak içindir
        //list<t> getall() fonksiyonu in memoryde dedir.
        //ıqueryable daha iyi yani
        IQueryable<T> GetWhere(Expression<Func<T, bool>>method, bool tracking = true);
        //şarta uygun olan birden fazla veriyi döndür diyecez içini doldururken
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        // datayı geriye task olarak döndürecek
        Task<T> GetByIdAsync(string id,bool tracking = true);

    }
}
