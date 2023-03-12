using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    // DTO klasörü veri tabanında join yapmak için kullanılan yapılardan biri. Entity nesnesi değil
    // çünkü tek başına bir tablo belirtmiyor.
    // Bu nedenle DTO ( Data Transformation Object) olarak adlandırılıyor.
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }


    }
}
