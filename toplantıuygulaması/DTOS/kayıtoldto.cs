using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplantıuygulaması.DTOS
{
    public class kayıtoldto
    {
        [Required(ErrorMessage ="kullanıcı adı bos olamaz")]
        public string kullanıcıadısı { get; set; }
        [Required(ErrorMessage = "sifre bos olamaz")]
        public string sifre { get; set; }
        [Compare("sifre",ErrorMessage ="sifreler uyusmuyor")]
        public string sifretekrar { get; set; }

    }
}
