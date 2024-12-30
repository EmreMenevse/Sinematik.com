using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinematik.com
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source = EMRE-PC;  Initial Catalog = sinematikDB;   Integrated Security = True");
        //SqlConnection conn = new SqlConnection(@"Data Source=; Integrated Security = True");



        //Kullanıcı Giriş İşlemleri
        private void btnGiris_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar where KADI=@username AND KSIFRE=@password", conn);
            sorgula.Parameters.AddWithValue("@username", txtYetkiliKisi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader read = sorgula.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                FrmAnaForm frmAnafrm = new FrmAnaForm();
                frmAnafrm.kisiAdiSoyadi = read["ADSOYAD"].ToString();
                frmAnafrm.Show();
                this.Hide();                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre hatalı");
                
            }
            conn.Close();
            txtYetkiliKisi.Text = "";
            txtSifre.Text = "";
            txtYetkiliKisi.Focus();

            //conn.Open();
            //if (conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Bağlantı oluşturuldu.");
            //}            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
