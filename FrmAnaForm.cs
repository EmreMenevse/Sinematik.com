using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinematik.com
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        public string kisiAdiSoyadi = "";
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz " + kisiAdiSoyadi);
        }
    }
}
