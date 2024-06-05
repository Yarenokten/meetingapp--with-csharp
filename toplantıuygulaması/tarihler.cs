using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toplantıuygulaması.DTOS;
using toplantıuygulaması.servisler;

namespace toplantıuygulaması
{
    public partial class tarihler : Form
    {
        private kullanıcıvetoplantıservice kullanıcıvetoplantıservice;
        List<toplantılistele> toplanti;
        kullanicilistele kullanici;
        katılımcılisteledto kullanıcıadısı; 
        public tarihler(kullanicilistele kullanici)
        {
            InitializeComponent();
            kullanıcıvetoplantıservice = new kullanıcıvetoplantıservice();
            this.kullanici = kullanici;
           
        }

        private async void tarihler_Load(object sender, EventArgs e)
        {
            await kullanıcıvetoplantıservice.Connection.StartAsync();
            kullanıcıvetoplantıservice.Connection.On<List<toplantılistele>>("toplantilarial",_toplantilar =>
            {
                toplanti = _toplantilar;
                dataGridView1.DataSource = toplanti.Select(x => new toplantılistele
                {
                    aciklama = x.aciklama,
                    baslik = x.baslik,
                    toplantıtarihleri = x.toplantıtarihleri,
                    toplantıId = x.toplantıId,
                    toplantıkodu = x.toplantıkodu,
                    kullanıcıId = x.kullanıcıId
                }).ToList();

            });
            await kullanıcıvetoplantıservice.Connection.InvokeAsync("toplantilarigetir");
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenhucre = dataGridView1.SelectedCells[0].RowIndex;//index değerini al bana ver
            string ToplantıId = dataGridView1.Rows[secilenhucre].Cells[0].Value.ToString();
            var toplantı = toplanti.FirstOrDefault(x => x.toplantıId == ToplantıId);
            checkBox1.Text = toplantı.toplantıtarihleri[0].ToString();
            checkBox2.Text = toplantı.toplantıtarihleri[1].ToString();

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var secilenhucre = dataGridView1.SelectedCells[0].RowIndex;//index değerini al bana ver
            string ToplantıId = dataGridView1.Rows[secilenhucre].Cells[0].Value.ToString();
            if(checkBox1.Checked || checkBox2.Checked)
            {
                var secilentarih=checkBox1.Checked ==true ? DateTime.Parse(checkBox1.Text) : DateTime.Parse(checkBox2.Text);
                var katılımcıdto = new katilimciekle2dto
                {
                    kullanıcıId = kullanici.kullanıcıId,
                    secilentarih = secilentarih,
                    toplantıId = ToplantıId,
                   
                     
                       
                };
                await kullanıcıvetoplantıservice.Connection.InvokeAsync("katilimciekle", katılımcıdto);

            }
            else
            {
                MessageBox.Show(" tarih seçiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            Process.Start("https://pdedtestapi.ibrahimbagislar.com/calendar/auth?meetingId=" + dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(kullanici);
            anasayfa.Show();
           Hide();
        }
    }
}
