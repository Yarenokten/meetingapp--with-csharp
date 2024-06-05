namespace toplantıuygulaması
{
    partial class girişekranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtkullanıcı = new System.Windows.Forms.TextBox();
            this.txtsifreolustur = new System.Windows.Forms.TextBox();
            this.btnkaydol = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadolustur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsifretekrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.txtsifretekrar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtkullanıcı);
            this.panel1.Controls.Add(this.txtsifreolustur);
            this.panel1.Controls.Add(this.btnkaydol);
            this.panel1.Controls.Add(this.btngiris);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtadolustur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsifre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 588);
            this.panel1.TabIndex = 13;
            // 
            // txtkullanıcı
            // 
            this.txtkullanıcı.BackColor = System.Drawing.Color.AliceBlue;
            this.txtkullanıcı.Location = new System.Drawing.Point(137, 69);
            this.txtkullanıcı.Multiline = true;
            this.txtkullanıcı.Name = "txtkullanıcı";
            this.txtkullanıcı.Size = new System.Drawing.Size(176, 20);
            this.txtkullanıcı.TabIndex = 2;
            // 
            // txtsifreolustur
            // 
            this.txtsifreolustur.BackColor = System.Drawing.Color.AliceBlue;
            this.txtsifreolustur.Location = new System.Drawing.Point(188, 280);
            this.txtsifreolustur.Multiline = true;
            this.txtsifreolustur.Name = "txtsifreolustur";
            this.txtsifreolustur.Size = new System.Drawing.Size(176, 20);
            this.txtsifreolustur.TabIndex = 9;
            // 
            // btnkaydol
            // 
            this.btnkaydol.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkaydol.Location = new System.Drawing.Point(113, 387);
            this.btnkaydol.Name = "btnkaydol";
            this.btnkaydol.Size = new System.Drawing.Size(99, 23);
            this.btnkaydol.TabIndex = 10;
            this.btnkaydol.Text = "KAYDOL";
            this.btnkaydol.UseVisualStyleBackColor = false;
            this.btnkaydol.Click += new System.EventHandler(this.btnkaydol_Click);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.AliceBlue;
            this.btngiris.Location = new System.Drawing.Point(113, 147);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(99, 23);
            this.btngiris.TabIndex = 11;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mevcut Hesaba Giriş Yap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(60, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şifre oluştur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // txtadolustur
            // 
            this.txtadolustur.BackColor = System.Drawing.Color.AliceBlue;
            this.txtadolustur.Location = new System.Drawing.Point(188, 246);
            this.txtadolustur.Multiline = true;
            this.txtadolustur.Name = "txtadolustur";
            this.txtadolustur.Size = new System.Drawing.Size(176, 20);
            this.txtadolustur.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kullanıcı adı oluştur:";
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtsifre.Location = new System.Drawing.Point(137, 104);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(176, 20);
            this.txtsifre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hesabınız yok ise kaydolun:\r\n";
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.BackColor = System.Drawing.Color.AliceBlue;
            this.txtsifretekrar.Location = new System.Drawing.Point(188, 324);
            this.txtsifretekrar.Multiline = true;
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.Size = new System.Drawing.Size(176, 20);
            this.txtsifretekrar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(60, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Şifreyi tekrar:";
            // 
            // girişekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::toplantıuygulaması.Properties.Resources.istockphoto_1255831272_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 612);
            this.Controls.Add(this.panel1);
            this.Name = "girişekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.girişekranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtkullanıcı;
        private System.Windows.Forms.TextBox txtsifreolustur;
        private System.Windows.Forms.Button btnkaydol;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadolustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsifretekrar;
        private System.Windows.Forms.Label label7;
    }
}

