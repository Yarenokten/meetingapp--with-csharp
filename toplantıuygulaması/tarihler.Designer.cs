namespace toplantıuygulaması
{
    partial class tarihler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toplantılisteleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toplantılisteleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toplantilisteledtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toplantıIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplantıkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplantılisteleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantilisteledtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(26, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "Geri\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Oluşturulmuş Toplantılar:\r\n";
            // 
            // toplantılisteleBindingSource
            // 
            this.toplantılisteleBindingSource.DataSource = typeof(toplantıuygulaması.DTOS.toplantılistele);
            // 
            // toplantılisteleBindingSource1
            // 
            this.toplantılisteleBindingSource1.DataSource = typeof(toplantıuygulaması.DTOS.toplantılistele);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toplantıIdDataGridViewTextBoxColumn,
            this.baslikDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.toplantıkoduDataGridViewTextBoxColumn,
            this.kullanıcıIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toplantılisteleBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 263);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toplantıIdDataGridViewTextBoxColumn
            // 
            this.toplantıIdDataGridViewTextBoxColumn.DataPropertyName = "toplantıId";
            this.toplantıIdDataGridViewTextBoxColumn.HeaderText = "toplantıId";
            this.toplantıIdDataGridViewTextBoxColumn.Name = "toplantıIdDataGridViewTextBoxColumn";
            // 
            // baslikDataGridViewTextBoxColumn
            // 
            this.baslikDataGridViewTextBoxColumn.DataPropertyName = "baslik";
            this.baslikDataGridViewTextBoxColumn.HeaderText = "baslik";
            this.baslikDataGridViewTextBoxColumn.Name = "baslikDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // toplantıkoduDataGridViewTextBoxColumn
            // 
            this.toplantıkoduDataGridViewTextBoxColumn.DataPropertyName = "toplantıkodu";
            this.toplantıkoduDataGridViewTextBoxColumn.HeaderText = "toplantıkodu";
            this.toplantıkoduDataGridViewTextBoxColumn.Name = "toplantıkoduDataGridViewTextBoxColumn";
            // 
            // kullanıcıIdDataGridViewTextBoxColumn
            // 
            this.kullanıcıIdDataGridViewTextBoxColumn.DataPropertyName = "kullanıcıId";
            this.kullanıcıIdDataGridViewTextBoxColumn.HeaderText = "kullanıcıId";
            this.kullanıcıIdDataGridViewTextBoxColumn.Name = "kullanıcıIdDataGridViewTextBoxColumn";
            // 
            // toplantılisteleBindingSource2
            // 
            this.toplantılisteleBindingSource2.DataSource = typeof(toplantıuygulaması.DTOS.toplantılistele);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(707, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(707, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 51;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(707, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 28);
            this.button3.TabIndex = 52;
            this.button3.Text = "Toplantıya kayıt ol\r\n\r\n\r\n\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(707, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 38);
            this.button2.TabIndex = 53;
            this.button2.Text = "Google Takvime ekle\r\n\r\n\r\n\r\n\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarihler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1381, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "tarihler";
            this.Text = "tarihler";
            this.Load += new System.EventHandler(this.tarihler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantilisteledtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplantılisteleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource toplantılisteleBindingSource;
        private System.Windows.Forms.BindingSource toplantılisteleBindingSource1;
        private System.Windows.Forms.BindingSource toplantilisteledtoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplantıIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplantıkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toplantılisteleBindingSource2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}