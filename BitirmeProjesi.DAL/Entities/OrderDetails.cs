using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.DAL.Entities
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

        [Display(Name = "Ürün ID")]
        public int ProductID { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(100), Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar(150)"), StringLength(150), Display(Name = "Ürün Resmi")]
        public string ProductPicture { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Ürün Fiyat Bilgisi")]
        public decimal ProductPrice { get; set; }

        public string ProductPriceFormatted
        {
            get
            {
                // Fiyatı "N" biçiminde (virgülden sonra 2 basamak) bir dizeye dönüştür
                string formattedFiyat = ProductPrice.ToString("N0");

                formattedFiyat += " ₺";

                return formattedFiyat;
            }
        }

        [Display(Name = "Miktar")]
        public int Quantity { get; set; }
    }
}
