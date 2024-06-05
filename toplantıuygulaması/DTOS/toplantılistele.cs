using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplantıuygulaması.DTOS
{
   public class toplantılistele
    {
        public string toplantıId { get; set; } 
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string toplantıkodu { get; set; } 
        public string kullanıcıId { get; set; }
        public List<DateTime> toplantıtarihleri { get; set; }
       
    }
}
