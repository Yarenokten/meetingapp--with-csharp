namespace toplantıuygulamasıserver.models
{
    public class toplantı
    {
        public string toplantıId { get; set; } = Guid.NewGuid().ToString();
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string toplantıkodu{ get; set; }= Guid.NewGuid().ToString().Substring(0,7).Replace("-","");
        public string kullanıcıId { get;set; }
        public List<DateTime> toplantıtarihleri { get; set; }
        public List<katilimci> katilimcilar { get; set; }

    }
}
