namespace Excell_Deneme_1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.RtxtIcerik = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOutputsPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenderMail = new System.Windows.Forms.TextBox();
            this.txtSenderPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "b";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(45, 34);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(496, 20);
            this.txtDosya.TabIndex = 1;
            // 
            // RtxtIcerik
            // 
            this.RtxtIcerik.Location = new System.Drawing.Point(45, 149);
            this.RtxtIcerik.Name = "RtxtIcerik";
            this.RtxtIcerik.Size = new System.Drawing.Size(296, 101);
            this.RtxtIcerik.TabIndex = 3;
            this.RtxtIcerik.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 101);
            this.button3.TabIndex = 4;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOutputsPath
            // 
            this.txtOutputsPath.Location = new System.Drawing.Point(45, 72);
            this.txtOutputsPath.Name = "txtOutputsPath";
            this.txtOutputsPath.Size = new System.Drawing.Size(496, 20);
            this.txtOutputsPath.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Output Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sender E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(121, 112);
            this.txtSenderMail.Name = "txtSenderMail";
            this.txtSenderMail.Size = new System.Drawing.Size(152, 20);
            this.txtSenderMail.TabIndex = 9;
            this.txtSenderMail.Text = "millimusa@gmail.com";
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.Location = new System.Drawing.Point(389, 112);
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.Size = new System.Drawing.Size(152, 20);
            this.txtSenderPassword.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(565, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 284);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSenderPassword);
            this.Controls.Add(this.txtSenderMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOutputsPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RtxtIcerik);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.RichTextBox RtxtIcerik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOutputsPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenderMail;
        private System.Windows.Forms.TextBox txtSenderPassword;
        private System.Windows.Forms.Button btnExit;
    }
}

