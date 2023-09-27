using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.DAL.Entities
{
    public class Product
    {
        public int ID { get;set; }

        [Column(TypeName="Varchar(100)"),StringLength(200),Display(Name ="Ürün Adı"),Required(ErrorMessage ="Ürün Adı boş bırakılamaz")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)"),  Display(Name = "Fiyat"), Required(ErrorMessage = "Fiyat boş bırakılamaz")]
        public decimal Fiyat { get; set; }


        
        public string FiyatFormatted
        {
            get
            {
                
                string formattedFiyat = Fiyat.ToString("N0");

                formattedFiyat += " ₺";

                return formattedFiyat;
            }
        }

        [Column(TypeName = "Varchar(100)"), StringLength(100), Display(Name = "Model"), Required(ErrorMessage = "Model Adı boş bırakılamaz")]
        public string Modeli { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(100), Display(Name = "Seri")]
        public string Seri { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(100), Display(Name = "Motor"), Required(ErrorMessage = "Motor boş bırakılamaz")]
        public string Motor { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(50), Display(Name = "Beygir"), Required(ErrorMessage = "Beygir boş bırakılamaz")]
        public string Beygir { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(50), Display(Name = "Vites"), Required(ErrorMessage = "Vites boş bırakılamaz")]
        public string Vites { get; set; }

        [Column(TypeName = "Varchar(MAX)"), Display(Name = "Açıklama"), Required(ErrorMessage = "Açıklama boş bırakılamaz")]
        public string Aciklama { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(100), Display(Name = "Stok Miktarı"), Required(ErrorMessage = "Stok Miktarı boş bırakılamaz")]
        public string StokMiktari { get; set; }


        [Display(Name ="Görüntülenme Sırası")]
        public int  DisplayIndex { get; set; }

        [Column(TypeName="text"),Display(Name="Ürün Detayı")]
        public string Detail { get; set; }

        [Column(TypeName = "text"), Display(Name = "Kargo Detayı")]
        public string CargoDetail { get; set; }


        public ICollection<ProductPicture> ProductPictures { get; set; }

        [Display(Name="Markası")]
        public int? BrandID { get; set; }   
        public Brand Brand { get; set; }

        [Display(Name ="Kategorisi")]
        public int? CategoryID { get; set; }    
        public Category Category { get; set; }

        
    }
}
