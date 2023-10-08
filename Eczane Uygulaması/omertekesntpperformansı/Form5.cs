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
    public partial class Form5 : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;


        void görüntüleme()
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM işlem", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneNTPDataSet.işlem' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.işlemTableAdapter.Fill(this.eczaneNTPDataSet.işlem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO işlem(cano,musno,ilacno,alimtarihi) VALUES (@cano,@musno,@ilaçno,@alimtarihi)";
            komut = new SqlCommand(sorgu, cn);

            komut.Parameters.AddWithValue("@cano", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@musno", Convert.ToInt32(textBox3.Text));
            komut.Parameters.AddWithValue("@ilaçno", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@alimtarihi", Convert.ToDateTime(textBox5.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from işlem where islemno=@islemno";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@islemno", Convert.ToInt32(textBox1.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM işlem WHERE islemno LIKE '%" +Convert.ToInt32(textBox6.Text) + "%'", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }
    }
}
