using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._17.Cuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void tarihAta(string strmesaj)
        {
            textBox1.Text = strmesaj;
        }


        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr= colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
            
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            label1.ForeColor = fontDialog1.Color;
        }

        private void btnKlasor_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////FrmYeni frm = new FrmYeni();
            //frm.Show();
            //label1 => private
            ////frm.lbl1.Text = textBox1.Text;
            //1-prop kullanarak
            ////frm.Mesaj = textBox1.Text;

            //2-Metod 
            ////frm.MesajAta(textBox1.Text);
            //3-Ctor
            FrmYeni frm = new FrmYeni(this,textBox1.Text);

            frm.ShowDialog();

        }
        public string Tarih
        { 
            get { return textBox1.Text; } 
            set { textBox1.Text = value; } 
        }
    }
}
