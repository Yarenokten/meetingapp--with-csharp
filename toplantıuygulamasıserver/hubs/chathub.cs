using Microsoft.AspNetCore.SignalR;
using toplantıuygulamasıserver.models;

namespace toplantıuygulamasıserver.hubs
{
    public class chathub:Hub
    {
        public static List<chatuser> users = new List<chatuser>();

        public async Task toplantıyakatılma(string toplantıId,string username)
        {
            var newchatuser = new chatuser
            {
                ConnectionId=Context.ConnectionId,
                UserName=username,
            };
            users.Add(newchatuser);
            await Groups.AddToGroupAsync(Context.ConnectionId, toplantıId);
            await Clients.OthersInGroup(toplantıId).SendAsync("katılankullanıcı", $"{username} toplantıya katıldı");
            

        }
        public async Task mesajgonder(string toplantıId, string username,string mesaj)
        {
            await Clients.OthersInGroup(toplantıId).SendAsync("gelenmesaj", $"{username} :{mesaj }");
        }
    }
}
