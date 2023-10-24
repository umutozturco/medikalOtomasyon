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
    public partial class yoneticiPaneli : Form
    {
        public yoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metal metal = new Metal();
            this.Hide();
            metal.ShowDialog();

        }

        private void btnElektronik_Click(object sender, EventArgs e)
        {
            Elektronik elektronik = new Elektronik();
            this.Hide();
            elektronik.ShowDialog();

        }

        private void btnOrtopedi_Click(object sender, EventArgs e)
        {
            Ortopedi ortopedi = new Ortopedi();
            this.Hide();
            ortopedi.ShowDialog();
        }

        private void btnPlastik_Click(object sender, EventArgs e)
        {
            Hastabakım hastabakım = new Hastabakım();
            this.Hide();
            hastabakım.ShowDialog();
        }

        private void btnSarf_Click(object sender, EventArgs e)
        {
            Sarf sarf = new Sarf();
            this.Hide();
            sarf.ShowDialog();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtSifre2.PasswordChar= '*';
            DateTime bugun = DateTime.Today;

            // Tarihi gün, ay ve yıl olarak biçimlendir
            string tarihMetni = bugun.ToString("dd/MM/yyyy"); // "dd/MM/yyyy" formatı gün/ay/yıl şeklinde yazdırır.

            // Label kontrolüne tarih metnini yazdır
            lblTarih.Text = tarihMetni;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "guneymedikal" && txtSifre.Text == "guney2150")
            {

                btnElektronik.Visible = true;
                btnOrtopedi.Visible = true;
                btnPlastik.Visible = true;
                btnSarf.Visible = true;
                btnMetal.Visible = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {

        }

        private void yoneticiPaneli_Resize(object sender, EventArgs e)
        {
            OrtalaNesneler();
        }
        private void OrtalaNesneler()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "guneymedikal" && txtSifre.Text == "guney2150")
            {
                btnSatisGoruntule.Visible = true;
                btnElektronik.Visible = true;
                btnOrtopedi.Visible = true;
                btnPlastik.Visible = true;
                btnSarf.Visible = true;
                btnMetal.Visible = true;
                btnGununCirosu.Visible = true;
                listboxCikar.Visible= true;
                listboxEkle.Visible= true;
                listboxTemizle.Visible= true;
                listbox1.Visible= true;
                txtSiparis.Visible= true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void btnSatisGoruntule_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            this.Hide();
            satislar.Show();

            OpenFileDialog openFileDialog = new OpenFileDialog();



        }

        private void btnGununCirosu_Click(object sender, EventArgs e)
        {
            string dogruSifre = "guney2150"; // Doğru şifreyi tanımlayın
            decimal toplamSatis = 0;
            txtSifre2.Visible = true;
            lblYetkiSifre.Visible = true;

            // Kullanıcıdan alınan şifre ile doğru şifreyi karşılaştır
            if (txtSifre2.Text == dogruSifre)
            {
                DateTime bugun = DateTime.Today.Date; // Sadece tarih kısmını al
                string sorgu = "SELECT SUM(satisFiyati) FROM satislar WHERE tarih = @bugun";

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ECG9JSB;Initial Catalog=guneyMedikal;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(sorgu, connection))
                    {
                        cmd.Parameters.AddWithValue("@bugun", bugun);
                        connection.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            toplamSatis = Convert.ToDecimal(result);
                        }

                        connection.Close();
                    }
                }

                MessageBox.Show("Bugünün cirosu: " + toplamSatis.ToString("N2"));
            }
            
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void listboxCikar_Click(object sender, EventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);

        }

        private void listboxEkle_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add(txtSiparis.Text);
        }

        private void listboxTemizle_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
        }
    }
}
    

