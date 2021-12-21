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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int adim = 5;
        bool yon = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Text = DateTime.Now.ToLongTimeString();

            //if (label1.Left < this.Width)
            //    label1.Left += 10;
            //else
            //    label1.Left = -label1.Width;

            
            if (yon)
            {
                if (label1.Right < this.Width)
                    label1.Left = label1.Left + adim;
                else
                    yon = false;
            }
            else if (yon == false)
            {
                if (label1.Left > 0)
                    label1.Left -= adim;
                else
                    yon = true;
            }



        }


    }
}
