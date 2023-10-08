using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace omertekesntpperformansı
{
    public partial class Form7 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;

        void görüntüleme()
        {

            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM CalisanBilgi", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();

        }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'eczaneNTPDataSet.CalisanBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanBilgiTableAdapter.Fill(this.eczaneNTPDataSet.CalisanBilgi);


        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from CalisanBilgi where @calisanno=CalisanNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@calisanno", Convert.ToInt32(textBox1.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO CalisanBilgi(Ad,Soyad,Cinsiyet,Telefon,Adres,Maas) VALUES (@ad,@soyad,@Cinsiyet,@Telefon,@Adres,@Maas)";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox4.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@Adres", textBox6.Text);
            komut.Parameters.AddWithValue("@Maas",Convert.ToInt32(textBox7.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE CalisanBilgi SET Ad = @ad , Soyad = @soyad , Cinsiyet = @Cinsiyet , Telefon = @Telefon , Adres = @Adres , Maas = @Maas WHERE CalisanNo = @CalisanNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@CalisanNo", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox4.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@Adres", textBox6.Text);
            komut.Parameters.AddWithValue("@Maas", textBox7.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM CalisanBilgi WHERE Ad LIKE '%" + textBox8.Text + "%'", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }
    }
}
