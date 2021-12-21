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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnsoltosağ_Click(object sender, EventArgs e)
        {
            if (Aksesuar.SelectedItem != null && !(SeçilenAksesuar.Items.Contains(Aksesuar.SelectedItem)))
            {
                SeçilenAksesuar.Items.Add(Aksesuar.SelectedItem);
            }

        }
        private void btnsagtosol_Click(object sender, EventArgs e)
        {
            if (SeçilenAksesuar.SelectedItem != null)
            {
                SeçilenAksesuar.Items.Remove(SeçilenAksesuar.SelectedItem);
            }
        }
        private void btnsoltosagall_Click(object sender, EventArgs e)
        {
            foreach (var item in Aksesuar.Items)
            {
                if (!(SeçilenAksesuar.Items.Contains(item)))
                    SeçilenAksesuar.Items.Add(item);
            }
        }
        private void btnsagtosolall_Click(object sender, EventArgs e)
        {
            int sayac = SeçilenAksesuar.Items.Count;

            for (int i = 0; i < sayac; i++)
            {
                SeçilenAksesuar.Items.Remove(SeçilenAksesuar.Items[0]);
            }
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.Write(txtPlaka.Text + ";" + cmbMarka.Text + ";" + txtModel.Text + ";");
            if (rdBinek.Checked == true)
                sw.Write(rdBinek.Text);
            else if (rdTicari.Checked == true)
                sw.Write(rdTicari.Text);
            foreach (var item in SeçilenAksesuar.Items)
                sw.Write(";" + item);
            sw.Write(";" + pictureBox1.ImageLocation);
            sw.Close();
        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            SeçilenAksesuar.Items.Clear();
            openFileDialog2.ShowDialog();
            StreamReader sr = new StreamReader(openFileDialog2.FileName);
            while (!sr.EndOfStream)
            {
                string[] bilgiler = sr.ReadLine().Split(';');
                txtPlaka.Text = bilgiler[0];
                cmbMarka.Text = bilgiler[1];
                txtModel.Text = bilgiler[2];
                if (bilgiler[3] == rdBinek.Text)
                    rdBinek.Checked = true;
                if (bilgiler[3] == rdTicari.Text)
                    rdTicari.Checked = true;
                for (int i = 4; i < bilgiler.Length - 1; i++)
                {
                    SeçilenAksesuar.Items.Add(bilgiler[i]);
                }
                pictureBox1.ImageLocation = bilgiler[bilgiler.Length - 1];
            }
            sr.Close();
            



            //fasdfasdf
            ////asdfasdfasdf


        }
    }
}
