namespace toplantıuygulamasıserver.DTOS
{
    public class toplantiolusturmadto
    {
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public List<DateTime> toplantitarihleri { get; set; }
        public string kullanıId { get; set; }

    }
}
