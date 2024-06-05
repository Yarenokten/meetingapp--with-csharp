using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

    public partial class girişekranı : Form
    {
        private kullanıcıvetoplantıservice kullanıcıvetoplantıservice;
        List<kullanicilistele> kullanıcılar;
        public girişekranı()
        {

            InitializeComponent();
            kullanıcıvetoplantıservice=new kullanıcıvetoplantıservice();
        }
        string userFilePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "girişbilgileri.json");
        private async void btnkaydol_Click(object sender, EventArgs e)
        {

            var kullanıcıdto = new kayıtoldto
            {
                kullanıcıadısı = txtadolustur.Text,
                sifre = txtsifreolustur.Text,
                sifretekrar = txtsifretekrar.Text,
            };
            ValidationContext context = new ValidationContext(kullanıcıdto);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Validator.TryValidateObject(kullanıcıdto, context, errors, true))
            {
                await kullanıcıvetoplantıservice.Connection.InvokeAsync("kullanicikaydet", kullanıcıdto);
                await kullanıcıvetoplantıservice.Connection.InvokeAsync("kullanicilarigetir");
                MessageBox.Show("kayıt olusturuldu");
            }
            else

                MessageBox.Show(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));



        }

        private async void btngiris_Click(object sender, EventArgs e)
        {
            var girisdto = new girişbilgileri
            {
                kuallnıcıadı = txtkullanıcı.Text,
                sifre = txtsifre.Text,
            };
            ValidationContext context = new ValidationContext(girisdto);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Validator.TryValidateObject(girisdto, context, errors, true))
            {
                var kullanıcı = kullanıcılar.FirstOrDefault(x => x.kullanıcıadısı == girisdto.kuallnıcıadı && x.sifre == girisdto.sifre);
                if (kullanıcı != null)
                {
                    MessageBox.Show("giriş başarılı yönlendirileceksiniz.");
                    anasayfa anasayfa = new anasayfa(kullanıcı);
                    anasayfa.Show();
                    this.Hide();
                }
                    
                else
                    MessageBox.Show("kullanıcı adı veya sifre yanlıs");
            }
            else

                MessageBox.Show(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));
        }

        private async void girişekranı_Load(object sender, EventArgs e)
        {
            await kullanıcıvetoplantıservice.Connection.StartAsync(); 
            kullanıcıvetoplantıservice.Connection.On<List<kullanicilistele>>("kullanicilarial", kullanıcılar => { this.kullanıcılar = kullanıcılar; }) ;
            await kullanıcıvetoplantıservice.Connection.InvokeAsync("kullanicilarigetir");



        }
    }
}
