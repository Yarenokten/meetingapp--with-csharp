using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toplantıuygulaması.DTOS;
using toplantıuygulaması.servisler;

namespace toplantıuygulaması
{
    public partial class anasayfa : Form
    {
        kullanicilistele user;
        private kullanıcıvetoplantıservice kullanıcıvetoplantıservice;
        List<toplantılistele> toplantılistesi;
        List<katılımcılisteledto> katılımcılisteledtos;
        katılımcılisteledto kullanıcıadısı;

        string userFilePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "toplantıbilgileri.json");
        public anasayfa(kullanicilistele user)
        {
            
            InitializeComponent();
            this.user = user;
            kullanıcıvetoplantıservice=new kullanıcıvetoplantıservice();
        }

        private async void anasayfa_Load(object sender, EventArgs e)
        {
            await kullanıcıvetoplantıservice.Connection.StartAsync();
            kullanıcıvetoplantıservice.Connection.On<List<toplantılistele>>("toplantilarial", toplantılar => { toplantılistesi = toplantılar; });
            await kullanıcıvetoplantıservice.Connection.InvokeAsync("toplantilarigetir");
            label1.Text = user.kullanıcıadısı;
            kullanıcıvetoplantıservice.Connection.On<List<katılımcılisteledto>>("katilimcilarial", katılımcılar => { katılımcılisteledtos = katılımcılar; });

        }

      

       

        private void btntoplantıolustur_Click(object sender, EventArgs e)
        {
            toplantıolusturmasayfası toplantıolusturmasayfası = new toplantıolusturmasayfası(user);
            toplantıolusturmasayfası.Show();
            this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var toplantıkodu = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(toplantıkodu))
            {
                var meeting = toplantılistesi.FirstOrDefault(x => x.toplantıkodu == toplantıkodu);
                if(meeting != null)
                {
                    //await kullanıcıvetoplantıservice.Connection.InvokeAsync("katilimciliste",meeting.toplantıId);
                    //if (katılımcılisteledtos.Any(x => x.kullanıcıId == user.kullanıcıId))
                    //{

                    //}
                    //else
                    //{
                    //    MessageBox.Show("katılımcı listesinde yoksunuz");
                    //}
                    canlıtoplantı canlıtoplantı = new canlıtoplantı(user,meeting);
                    canlıtoplantı.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("toplantı bulunamadı");

                }
            }
            else
            {
                MessageBox.Show("toplantı kodu boş olamaz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarihler tümtoplantılar = new tarihler(user);
            tümtoplantılar.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
