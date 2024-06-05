namespace toplantıuygulamasıserver.models
{
    public class kullanıcı
    {
        public string kullanıcıId { get; set; }=Guid.NewGuid().ToString();//otomatik ıd olusturak
        public string kullanıcıadısı { get; set; }
        public string sifre { get; set; }
      
    }
}
