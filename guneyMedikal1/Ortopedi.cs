using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guneyMedikal1
{
    public partial class Ortopedi : Form
    {
        public Ortopedi()
        {
            InitializeComponent();
        }
        private SqlConnection baglanti;
        private double toplamFiyat = 0;

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True";
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into ortopedi (urunKodu,urunAdi,stokAdedi,gelisFiyati,satisFiyati)values(@urunKodu,@urunAdi,@stokAdedi,@gelisFiyati,@satisFiyati)";

            cmd.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@stokAdedi", txtStokAdedi.Text);
            cmd.Parameters.AddWithValue("@gelisFiyati", txtGelisFiyati.Text);
            cmd.Parameters.AddWithValue("@satisFiyati", txtSatisFiyati.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ürün Eklendi.");
            }
            else
            {
                MessageBox.Show("Ürün Eklenemedi.");
            }
            Goster();
        }
        void Goster()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True";
            conn.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select * from ortopedi order by urunAdi", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Ortopedi_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True";
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "update ortopedi set urunAdi=@urunAdi,stokAdedi=@stokAdedi,gelisFiyati=@gelisFiyati,satisFiyati=@satisFiyati where urunKodu=@urunKodu";

            cmd.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@stokAdedi", txtStokAdedi.Text);
            cmd.Parameters.AddWithValue("@gelisFiyati", txtGelisFiyati.Text);
            cmd.Parameters.AddWithValue("@satisFiyati", txtSatisFiyati.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ürün Güncellendi.");
            }
            else
            {
                MessageBox.Show("Ürün Güncellenemedi.");
            }
            Goster();
            txtUrunAdi.Text = "";
            txtStokAdedi.Text = "";
            txtUrunKodu.Text = "";
            txtSatisFiyati.Text = "";
            txtGelisFiyati.Text = "";
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True";
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "delete from ortopedi where urunKodu = @urunKodu";

            cmd.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@stokAdedi", txtStokAdedi.Text);
            cmd.Parameters.AddWithValue("@gelisFiyati", txtGelisFiyati.Text);
            cmd.Parameters.AddWithValue("@satisFiyati", txtSatisFiyati.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ürün Silindi.");
            }
            else
            {
                MessageBox.Show("Ürün Silinemedi.");
            }
            Goster();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox6.Text.Trim(); 

            
            string query = "SELECT * FROM ortopedi WHERE urunAdi" +
                "" +
                " LIKE @searchText";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); 
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnCiroGoster_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            string urunKodu = txtUrunKodu.Text;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select stokAdedi,satisFiyati from ortopedi where urunKodu = @urunKodu", connection);
            cmd.Parameters.AddWithValue("@urunKodu", urunKodu);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int stokAdedi = Convert.ToInt32(reader["stokAdedi"]);
                int satisFiyati = Convert.ToInt32(reader["satisFiyati"]);
                if (stokAdedi > 0)
                {
                    stokAdedi--;
                    SqlCommand stokGuncelle = new SqlCommand("update ortopedi set stokAdedi = @stokAdedi where urunKodu = @urunKodu", connection);
                    stokGuncelle.Parameters.AddWithValue("@stokAdedi", stokAdedi);
                    stokGuncelle.Parameters.AddWithValue("@urunKodu", urunKodu);
                    reader.Close();
                    stokGuncelle.ExecuteNonQuery();
                    toplamFiyat += satisFiyati;
                    
                    SqlCommand satisEkle = new SqlCommand("INSERT INTO satislar (urunKodu, urunAdi, satisFiyati,tarih) VALUES (@urunKodu, @urunAdi,@satisFiyati,@tarih)", connection);
                    satisEkle.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
                    satisEkle.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                    satisEkle.Parameters.AddWithValue("@satisFiyati", txtSatisFiyati.Text);
                    satisEkle.Parameters.AddWithValue("@tarih", DateTime.Now);
                    satisEkle.ExecuteNonQuery();


                }
                else
                {
                    MessageBox.Show("Bu ürün stokta yok");
                }
                Goster();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı");
            }
            Goster();
        }

        private void btnCiroGizle_Click(object sender, EventArgs e)
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

        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
            string arananUrunKodu = txtUrunKodu.Text;

            // DataGridView'da dolaşarak aranan ürün kodunu bulun.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["urunKodu"].Value != null && row.Cells["urunKodu"].Value.ToString() == arananUrunKodu)
                {
                    // Ürün kodu eşleşti, diğer verileri TextBox'lara yazın.
                    txtUrunAdi.Text = row.Cells["urunAdi"].Value.ToString();
                    txtSatisFiyati.Text = row.Cells["satisFiyati"].Value.ToString();
                    txtStokAdedi.Text = row.Cells["stokAdedi"].Value.ToString();
                    break; // İlk eşleşmeyi bulduktan sonra döngüyü sonlandırabilirsiniz.
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Seçilen satırın verilerine erişebilirsiniz.
                string urunKodu = selectedRow.Cells["urunKodu"].Value.ToString();
                string urunAdi = selectedRow.Cells["urunAdi"].Value.ToString();
                string gelisFiyati = selectedRow.Cells["gelisFiyati"].Value.ToString();
                                                                                
                txtUrunKodu.Text = urunKodu;
                txtUrunAdi.Text = urunAdi;
                txtGelisFiyati.Text = gelisFiyati;

                
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            string arananUrunAdi = txtUrunAdi.Text;

            // DataGridView'da dolaşarak aranan ürün kodunu bulun.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["urunAdi"].Value != null && row.Cells["urunAdi"].Value.ToString() == arananUrunAdi)
                {
                    // Ürün kodu eşleşti, diğer verileri TextBox'lara yazın.
                    txtUrunKodu.Text = row.Cells["urunKodu"].Value.ToString();
                    txtSatisFiyati.Text = row.Cells["satisFiyati"].Value.ToString();
                    txtStokAdedi.Text = row.Cells["stokAdedi"].Value.ToString();
                    
                    break; // İlk eşleşmeyi bulduktan sonra döngüyü sonlandırabilirsiniz.
                }
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }

    
}   

