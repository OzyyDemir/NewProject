using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime="Sistem bakımda";

        public static string ProductsListed="Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Fazla ürün oldu ekleyemez artık";

        public static string ProductNameAlreadyExists = "Bu isimli üründen zaten listede var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
