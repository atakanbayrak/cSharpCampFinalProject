using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //Static olarak constant mesajlarımızı tanımladık. Bu sayede newlenmeden çağırılabilecekler.
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda!";
        public static string ProductsListed = "Ürünler Listelendi!";
        internal static object ProductDetailListed = "Ürün Detayları Listelendi!";
    }
}
