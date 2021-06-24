using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";        
        public static string PrductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir";
        public static string ProductNameAlreadyExists = "Bu İsimde Bir Ürün Daha Önce Eklendi";
        public static string CategoryLimitExceded = "Kategori Limiti 15'i Geçtiği İçin Yeni Ürün Eklenemiyor";
    }
}
