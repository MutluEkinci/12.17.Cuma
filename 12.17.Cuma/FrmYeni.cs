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
    public partial class FrmYeni : Form
    {
        public FrmYeni()
        {
            InitializeComponent();
        }
        public FrmYeni(string mesaj)
        {
            InitializeComponent();
            lbl1.Text = mesaj;
        }

        Form1 _frm;
        public FrmYeni(Form1 form1,string mesaj)
        {
            InitializeComponent();
            lbl1.Text = mesaj;
            _frm = form1;
        }

        public void MesajAta(string strmesaj)
        {
            lbl1.Text = strmesaj;
        }

        private void FrmYeni_Load(object sender, EventArgs e)
        {

        }

        public string Mesaj 
        { 
            get { return lbl1.Text; } 
            set { lbl1.Text = value; } 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            _frm.Tarih = e.Start.ToLongDateString();
            this.Close();
            
            //MessageBox.Show(e.Start.ToLongDateString());
            
        }
        
        
    }
}
