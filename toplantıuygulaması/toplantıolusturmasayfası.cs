using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toplantıuygulaması.DTOS;
using toplantıuygulaması.servisler;

namespace toplantıuygulaması
{

    public partial class toplantıolusturmasayfası : Form   
    {
        private kullanıcıvetoplantıservice kullanıcıvetoplantıservice;
        kullanicilistele kullanıcı;

        public toplantıolusturmasayfası(kullanicilistele kullanıcı)
        {
            InitializeComponent();
            kullanıcıvetoplantıservice=new kullanıcıvetoplantıservice();
            this.kullanıcı = kullanıcı;
            
        }

        private async void toplantıolusturmasayfası_Load(object sender, EventArgs e)
        {
            await kullanıcıvetoplantıservice.Connection.StartAsync();
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var toplantıdto = new toplantıolusturdto
            {
                aciklama = txtacıklama.Text,
                baslik = txtbaslık.Text,
                toplantitarihleri = new List<DateTime> { dateTimePicker1.Value ,dateTimePicker2.Value },
                kullanıId = kullanıcı.kullanıcıId


            };
            ValidationContext context=new ValidationContext(toplantıdto);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Validator.TryValidateObject(toplantıdto, context, errors, true))
            {
                await kullanıcıvetoplantıservice.Connection.InvokeAsync("toplantiolustur", toplantıdto);
                MessageBox.Show("toplantı olusturuldu");
                
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine,errors.Select(x=>x.ErrorMessage )));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa=new anasayfa(kullanıcı);
            anasayfa.Show();
            Hide();
        }
    }
}
