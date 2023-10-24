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

namespace guneyMedikal1
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-ECG9JSB ;Initial Catalog=guneyMedikal;Integrated Security=True";
            conn.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select*from satislar", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btnYoneticiPaneli_Click(object sender, EventArgs e)
        {
            yoneticiPaneli panel = new yoneticiPaneli();
            this.Hide();
            panel.Show();
            panel.btnElektronik.Visible = true;

            panel.btnMetal.Visible = true;
            panel.btnOrtopedi.Visible = true;
            panel.btnPlastik.Visible = true;
            panel.btnSarf.Visible = true;
            
            panel.btnSatisGoruntule.Visible = true;
            panel.btnGununCirosu.Visible = true;
            panel.label2.Visible = false;
            panel.label3.Visible = false;
            panel.txtKullaniciAdi.Visible = false;
            panel.txtSifre.Visible = false;
            panel.button1.Visible = false;

            panel.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
