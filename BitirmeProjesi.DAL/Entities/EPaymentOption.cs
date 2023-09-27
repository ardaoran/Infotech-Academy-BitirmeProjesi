using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.DAL.Entities
{
    public enum EPaymentOption
    {
        [Display(Name = "Bayiden Ödeme")]
        Bayiden=2,

        [Display(Name="Kredi Kartı İle Ödeme")]
        KrediKartı=1 
    }
}
