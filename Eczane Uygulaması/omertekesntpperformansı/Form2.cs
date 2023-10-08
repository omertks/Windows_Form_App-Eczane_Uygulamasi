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
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;
        SqlDataReader dr;

        void görüntüleme()
        {

            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM kullanicigiris", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneNTPDataSet.kullanicigiris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicigirisTableAdapter.Fill(this.eczaneNTPDataSet.kullanicigiris);
            // TODO: Bu kod satırı 'eczaneNTPDataSet.admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.eczaneNTPDataSet.admin);

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO kullanicigiris(kullaniciadi,sifre) VALUES (@kullaniciadi,@sifre)";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox2.Text);
            komut.Parameters.AddWithValue("@sifre", textBox3.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from kullanicigiris where @id = id";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE kullanicigiris SET kullaniciadi = @kullaniciadi , sifre = @sifre WHERE id = @id";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@kullaniciadi", textBox2.Text);
            komut.Parameters.AddWithValue("@sifre", textBox3.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); 
            form8.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM kullanicigiris Where kullaniciadi  LIKE '%" + textBox4.Text + "%'", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }
    }
}
