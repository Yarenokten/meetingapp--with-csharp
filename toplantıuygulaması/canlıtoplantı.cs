using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toplantıuygulaması.DTOS;
using toplantıuygulaması.servisler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace toplantıuygulaması
{
    public partial class canlıtoplantı : Form
    {
        private kullanicilistele user;
        private toplantılistele toplantı;
        chatservis chatservis;

        public canlıtoplantı(kullanicilistele user, toplantılistele toplantı)
        {
            InitializeComponent();
            this.user = user;
            chatservis = new chatservis();
            this.toplantı = toplantı;
        }

        private async void canlıtoplantı_Load(object sender, EventArgs e)
        {
            label1.Text = toplantı.baslik;
            await chatservis.Connection.StartAsync();
            chatservis.Connection.On<string>("katılankullanıcı", mesaj =>
            {
                lstMessage.Items.Add(mesaj);

            });
            await chatservis.Connection.InvokeAsync("toplantıyakatılma", toplantı.toplantıId, user.kullanıcıadısı);
            chatservis.Connection.On<string>("gelenmesaj", mesaj =>
            {
                lstMessage.Items.Add(mesaj);

            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var mesaj=txtMessage.Text;
            if (!string.IsNullOrWhiteSpace(mesaj))
            {
                await chatservis.Connection.InvokeAsync("mesajgonder", toplantı.toplantıId, user.kullanıcıadısı, mesaj);
                lstMessage.Items.Add($"ben :{mesaj}");
            }
            else
                MessageBox.Show("mesaj giriniz");
        }

        private void lblMeetingTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
