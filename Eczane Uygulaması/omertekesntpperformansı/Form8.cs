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
    public partial class Form8 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;

        void görüntüleme()
        {

            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM ilaclar", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();

        }

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneNTPDataSet.ilaclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilaclarTableAdapter.Fill(this.eczaneNTPDataSet.ilaclar);

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ilaclar where İlacNo=@İlacNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@İlacNo", Convert.ToInt32(textBox1.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ilaclar(İlacTur,İlacAd,Fiyat,Recete,Adet) VALUES (@İlacTur,@İlacAd,@Fiyat,@Recete,@Adet)";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@İlacTur", textBox2.Text);
            komut.Parameters.AddWithValue("@İlacAd", textBox3.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox4.Text);
            komut.Parameters.AddWithValue("@Recete", textBox5.Text);
            komut.Parameters.AddWithValue("@Adet", textBox6.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ilaclar SET İlacTur = @İlacTur , İlacAd = @İlacAd , Fiyat = @Fiyat , Recete = @Recete , Adet = @Adet WHERE İlacNo = @İlacNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@İlacNo", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@İlacTur", textBox2.Text);
            komut.Parameters.AddWithValue("@İlacAd", textBox3.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox4.Text);
            komut.Parameters.AddWithValue("@Recete", textBox5.Text);
            komut.Parameters.AddWithValue("@Adet", textBox6.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM ilaclar Where İlacAd  LIKE '%" + textBox7.Text + "%'", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }
    }
}
