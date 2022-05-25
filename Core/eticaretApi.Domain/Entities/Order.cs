using eticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretApi.Domain.Entities
{
    public class Order:BaseEntity
    {
        public Guid CustomerId { get; set; }
        //bu cusotmer id ismini otomatik algılayacak
        // ve burdaki customera ıd kolobu otomatik
        //kendi ekleyecek
        public string Description { get; set; }
        public string Address { get; set; }
        //adress aslında bölünebilir
        //şehir, semt, sokak gibi bölünebilir.
        //ilerde düzenlenecek
        //order ile product arasında çoka çok ilişki var
        //çoktan bir olana ıcollection referansı veirlir
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
        //bir tane customerin olabilir.
    }
}
