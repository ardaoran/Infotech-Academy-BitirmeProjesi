using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.DAL.Entities
{
    public class Slide
    {
        public int ID { get;set; }

        [Column(TypeName="Varchar(100)"),StringLength(50),Display(Name ="Slogan1")]
        public string Slogan1 { get; set; }

        [Column(TypeName = "Varchar(100)"), StringLength(50), Display(Name = "Slogan2")]
        public string Slogan2 { get; set; }


        [Column(TypeName = "Varchar(150)"), StringLength(50), Display(Name = "Resim")]
        public string? Picture { get; set; }


        [Column(TypeName = "Varchar(150)"), StringLength(150), Display(Name = "Link Adresi")]
        public string Link { get; set; }

        [Display(Name ="Görüntülenme Sırası")]
        public int  DisplayIndex { get; set; }    


    }
}
