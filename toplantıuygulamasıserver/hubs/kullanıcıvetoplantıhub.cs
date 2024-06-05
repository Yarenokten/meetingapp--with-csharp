using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using toplantıuygulamasıserver.DTOS;
using toplantıuygulamasıserver.models;
using toplantıuygulamasıserver.Static;

namespace toplantıuygulamasıserver.hubs
{
    public class kullanıcıvetoplantıhub:Hub
    {
        public async Task kullanıcıkaydet(kullanıcıolusturmadto dto)
        {
            var userlistjson = System.IO.File.ReadAllText(jsonpath.girişbilgileri);
            var userlist=JsonConvert.DeserializeObject<List<kullanıcı>>(userlistjson);
            var yenikullanici = new kullanıcı
            {
                kullanıcıadısı = dto.kullanıcıadısı,
                sifre = dto.sifre,

            };
            userlist.Add(yenikullanici);
            var newuserlistjson=JsonConvert.SerializeObject(userlist);
            System.IO.File.WriteAllText(jsonpath.girişbilgileri, newuserlistjson);

        }
        public async Task kullanicilarigetir()
        {
            var userlistjson = System.IO.File.ReadAllText(jsonpath.girişbilgileri);
            var userlist = JsonConvert.DeserializeObject<List<kullanıcı>>(userlistjson);
            await Clients.Caller.SendAsync("kullanicilarial", userlist);

        }
        public async Task toplantiolustur(toplantiolusturmadto dto)
        {
            var meetinglistjson = System.IO.File.ReadAllText(jsonpath.toplantıbilgileri);
            var meetinglist = JsonConvert.DeserializeObject<List<toplantı>>(meetinglistjson);
            var newyenitoplatı = new toplantı
            {

                aciklama = dto.aciklama,
                baslik = dto.baslik,
                katilimcilar =new List<katilimci>(),
                kullanıcıId=dto.kullanıId,
                toplantıtarihleri=dto.toplantitarihleri
            };
            meetinglist.Add(newyenitoplatı);
            var newmeetinglistjson=JsonConvert.SerializeObject(meetinglist);
            System.IO.File.WriteAllText(jsonpath.toplantıbilgileri, newmeetinglistjson);

        }
        public async Task toplantilarigetir()
        {

            var meetinglistjson = System.IO.File.ReadAllText(jsonpath.toplantıbilgileri);
            var meetinglist = JsonConvert.DeserializeObject<List<toplantı>>(meetinglistjson);
            await Clients.Caller.SendAsync("toplantilarial", meetinglist);
        }
        public async Task katilimciekle(katilimciekledto dto)
        {

            var meetinglistjson = System.IO.File.ReadAllText(jsonpath.toplantıbilgileri);
            var meetinglist = JsonConvert.DeserializeObject<List<toplantı>>(meetinglistjson);
            var meeting=meetinglist.FirstOrDefault(x=>x.toplantıId==dto.toplantıId);
            var yenikatılımcı = new katilimci
            {
                kullanıcıId=dto.kullanıcıId,
                secilentarih=dto.secilentarih,

            };
            meeting.katilimcilar.Add(yenikatılımcı);
            var newmeetinglistjson = JsonConvert.SerializeObject(meetinglist);
            System.IO.File.WriteAllText(jsonpath.toplantıbilgileri, newmeetinglistjson);
        }
        public async Task katilimciliste(string toplantiId)
        {
            var meetinglistjson = System.IO.File.ReadAllText(jsonpath.toplantıbilgileri);
            var meetinglist = JsonConvert.DeserializeObject<List<toplantı>>(meetinglistjson);
            await Clients.Caller.SendAsync("katilimcilarial",meetinglist.FirstOrDefault(x=>x.toplantıId==toplantiId).katilimcilar);

        }
    }
}
