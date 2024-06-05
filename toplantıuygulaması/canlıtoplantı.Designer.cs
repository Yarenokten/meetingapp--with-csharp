namespace toplantıuygulaması
{
    partial class canlıtoplantı
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.lblMeetingTitle = new System.Windows.Forms.Label();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblInfo.Location = new System.Drawing.Point(463, 303);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 110);
            this.button1.TabIndex = 10;
            this.button1.Text = "MESAJ GÖNDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(463, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mesaj:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(466, 61);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(313, 230);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.Text = "";
            // 
            // lblMeetingTitle
            // 
            this.lblMeetingTitle.AutoSize = true;
            this.lblMeetingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeetingTitle.Location = new System.Drawing.Point(27, 27);
            this.lblMeetingTitle.Name = "lblMeetingTitle";
            this.lblMeetingTitle.Size = new System.Drawing.Size(52, 18);
            this.lblMeetingTitle.TabIndex = 7;
            this.lblMeetingTitle.Text = "label1";
            this.lblMeetingTitle.Click += new System.EventHandler(this.lblMeetingTitle_Click);
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.Location = new System.Drawing.Point(27, 61);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(378, 368);
            this.lstMessage.TabIndex = 6;
            // 
            // canlıtoplantı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1206, 592);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMeetingTitle);
            this.Controls.Add(this.lstMessage);
            this.Name = "canlıtoplantı";
            this.Text = "canlıtoplantı";
            this.Load += new System.EventHandler(this.canlıtoplantı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label lblMeetingTitle;
        private System.Windows.Forms.ListBox lstMessage;
    }
}