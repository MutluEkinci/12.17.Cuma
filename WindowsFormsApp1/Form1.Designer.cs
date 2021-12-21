
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.BoxTur = new System.Windows.Forms.GroupBox();
            this.rdTicari = new System.Windows.Forms.RadioButton();
            this.rdBinek = new System.Windows.Forms.RadioButton();
            this.Aksesuar = new System.Windows.Forms.ListBox();
            this.btnsoltosağ = new System.Windows.Forms.Button();
            this.btnsagtosol = new System.Windows.Forms.Button();
            this.btnsoltosagall = new System.Windows.Forms.Button();
            this.btnsagtosolall = new System.Windows.Forms.Button();
            this.SeçilenAksesuar = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BoxTur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(12, 34);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(43, 17);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 64);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 92);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Mercedes",
            "Audi",
            "Hyundai",
            "Ferrari",
            "Lamborghini",
            "Mclaren"});
            this.cmbMarka.Location = new System.Drawing.Point(87, 57);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 3;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(87, 29);
            this.txtPlaka.MaxLength = 15;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 22);
            this.txtPlaka.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(87, 87);
            this.txtModel.MaxLength = 50;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 5;
            // 
            // BoxTur
            // 
            this.BoxTur.Controls.Add(this.rdTicari);
            this.BoxTur.Controls.Add(this.rdBinek);
            this.BoxTur.Location = new System.Drawing.Point(16, 116);
            this.BoxTur.Name = "BoxTur";
            this.BoxTur.Size = new System.Drawing.Size(162, 74);
            this.BoxTur.TabIndex = 6;
            this.BoxTur.TabStop = false;
            this.BoxTur.Text = "Türü";
            // 
            // rdTicari
            // 
            this.rdTicari.AutoSize = true;
            this.rdTicari.Location = new System.Drawing.Point(87, 31);
            this.rdTicari.Name = "rdTicari";
            this.rdTicari.Size = new System.Drawing.Size(64, 21);
            this.rdTicari.TabIndex = 1;
            this.rdTicari.TabStop = true;
            this.rdTicari.Text = "Ticari";
            this.rdTicari.UseVisualStyleBackColor = true;
            // 
            // rdBinek
            // 
            this.rdBinek.AutoSize = true;
            this.rdBinek.Location = new System.Drawing.Point(6, 31);
            this.rdBinek.Name = "rdBinek";
            this.rdBinek.Size = new System.Drawing.Size(64, 21);
            this.rdBinek.TabIndex = 0;
            this.rdBinek.TabStop = true;
            this.rdBinek.Text = "Binek";
            this.rdBinek.UseVisualStyleBackColor = true;
            // 
            // Aksesuar
            // 
            this.Aksesuar.FormattingEnabled = true;
            this.Aksesuar.ItemHeight = 16;
            this.Aksesuar.Items.AddRange(new object[] {
            "ABS",
            "ASR",
            "SunRoof",
            "CD-Player"});
            this.Aksesuar.Location = new System.Drawing.Point(12, 220);
            this.Aksesuar.Name = "Aksesuar";
            this.Aksesuar.Size = new System.Drawing.Size(120, 132);
            this.Aksesuar.TabIndex = 7;
            // 
            // btnsoltosağ
            // 
            this.btnsoltosağ.Location = new System.Drawing.Point(138, 220);
            this.btnsoltosağ.Name = "btnsoltosağ";
            this.btnsoltosağ.Size = new System.Drawing.Size(75, 23);
            this.btnsoltosağ.TabIndex = 8;
            this.btnsoltosağ.Text = ">";
            this.btnsoltosağ.UseVisualStyleBackColor = true;
            this.btnsoltosağ.Click += new System.EventHandler(this.btnsoltosağ_Click);
            // 
            // btnsagtosol
            // 
            this.btnsagtosol.Location = new System.Drawing.Point(138, 249);
            this.btnsagtosol.Name = "btnsagtosol";
            this.btnsagtosol.Size = new System.Drawing.Size(75, 23);
            this.btnsagtosol.TabIndex = 9;
            this.btnsagtosol.Text = "<";
            this.btnsagtosol.UseVisualStyleBackColor = true;
            this.btnsagtosol.Click += new System.EventHandler(this.btnsagtosol_Click);
            // 
            // btnsoltosagall
            // 
            this.btnsoltosagall.Location = new System.Drawing.Point(138, 278);
            this.btnsoltosagall.Name = "btnsoltosagall";
            this.btnsoltosagall.Size = new System.Drawing.Size(75, 23);
            this.btnsoltosagall.TabIndex = 10;
            this.btnsoltosagall.Text = ">>";
            this.btnsoltosagall.UseVisualStyleBackColor = true;
            this.btnsoltosagall.Click += new System.EventHandler(this.btnsoltosagall_Click);
            // 
            // btnsagtosolall
            // 
            this.btnsagtosolall.Location = new System.Drawing.Point(138, 309);
            this.btnsagtosolall.Name = "btnsagtosolall";
            this.btnsagtosolall.Size = new System.Drawing.Size(75, 23);
            this.btnsagtosolall.TabIndex = 11;
            this.btnsagtosolall.Text = "<<";
            this.btnsagtosolall.UseVisualStyleBackColor = true;
            this.btnsagtosolall.Click += new System.EventHandler(this.btnsagtosolall_Click);
            // 
            // SeçilenAksesuar
            // 
            this.SeçilenAksesuar.FormattingEnabled = true;
            this.SeçilenAksesuar.ItemHeight = 16;
            this.SeçilenAksesuar.Location = new System.Drawing.Point(219, 220);
            this.SeçilenAksesuar.Name = "SeçilenAksesuar";
            this.SeçilenAksesuar.Size = new System.Drawing.Size(120, 132);
            this.SeçilenAksesuar.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(307, 167);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(105, 23);
            this.btnResimYukle.TabIndex = 14;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(390, 290);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 64);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(390, 220);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(105, 64);
            this.btnAc.TabIndex = 16;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Tüm Dosyalar|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 378);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SeçilenAksesuar);
            this.Controls.Add(this.btnsagtosolall);
            this.Controls.Add(this.btnsoltosagall);
            this.Controls.Add(this.btnsagtosol);
            this.Controls.Add(this.btnsoltosağ);
            this.Controls.Add(this.Aksesuar);
            this.Controls.Add(this.BoxTur);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblPlaka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BoxTur.ResumeLayout(false);
            this.BoxTur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.GroupBox BoxTur;
        private System.Windows.Forms.RadioButton rdTicari;
        private System.Windows.Forms.RadioButton rdBinek;
        private System.Windows.Forms.ListBox Aksesuar;
        private System.Windows.Forms.Button btnsoltosağ;
        private System.Windows.Forms.Button btnsagtosol;
        private System.Windows.Forms.Button btnsoltosagall;
        private System.Windows.Forms.Button btnsagtosolall;
        private System.Windows.Forms.ListBox SeçilenAksesuar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

