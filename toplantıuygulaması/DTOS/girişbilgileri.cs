using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplantıuygulaması.DTOS
{
    public class girişbilgileri
    {
        [Required(ErrorMessage ="kullanıcı adını düzgün gir")]
        public string kuallnıcıadı { get; set; }
        [Required(ErrorMessage = "sifreyi düzgün gir")]
        public string sifre { get; set; }
    }
}
