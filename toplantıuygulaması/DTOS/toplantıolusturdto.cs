using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplantıuygulaması.DTOS
{
    public class toplantıolusturdto
    {
        [Required(ErrorMessage =("baslık girilmedi"))]
        public string baslik { get; set; }
        [Required(ErrorMessage = ("acıklama girilmedi"))]
        public string aciklama { get; set; }
        
        public List<DateTime> toplantitarihleri { get; set; }

        public string kullanıId { get; set; }
    }
}
