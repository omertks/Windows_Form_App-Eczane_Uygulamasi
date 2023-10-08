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
    public partial class Form6 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;
        public Form6()
        {
            InitializeComponent();
        }

        void görüntüleme()
        {

            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Müşteribilgi", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneNTPDataSet.Müşteribilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müşteribilgiTableAdapter.Fill(this.eczaneNTPDataSet.Müşteribilgi);


        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE MusteriKayit SET Ad=@ad SET Soyad=@soyad SET CinsiyetNo=@CinsiyetNo SET TcNo=@TcNo SET DogumT=@DogumT SET TelNo=@TelNo WHERE MusteriNo=@MusteriNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@MusteriNo", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@CinsiyetNo", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@TcNo", textBox5.Text);
            komut.Parameters.AddWithValue("@dogum_t", textBox6.Text);
            komut.Parameters.AddWithValue("@AdresNo", Convert.ToInt32(textBox7.Text));
            komut.Parameters.AddWithValue("@TelNo", Convert.ToInt32(textBox8.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Müşteribilgi(Ad,Soyad,Cinsiyet,TcNo,DogumT,Adres,Telefon) VALUES (@ad,@soyad,@Cinsiyet,@TcNo,@dogum_t,@Adres,@Telefon)";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox4.Text);
            komut.Parameters.AddWithValue("@TcNo", textBox5.Text);
            komut.Parameters.AddWithValue("@dogum_t", textBox6.Text);
            komut.Parameters.AddWithValue("@Adres", textBox7.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox8.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from Müşteribilgi where @no=MüşteriNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Müşteribilgi SET Ad = @ad , Soyad = @soyad , Cinsiyet = @Cinsiyet , TcNo = @TcNo , DogumT = @DogumT , Adres = @Adres , Telefon = @TelNo WHERE MüşteriNo = @MusteriNo";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@MusteriNo", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox4.Text);
            komut.Parameters.AddWithValue("@TcNo", textBox5.Text);
            komut.Parameters.AddWithValue("@DogumT", textBox6.Text);
            komut.Parameters.AddWithValue("@Adres", textBox7.Text);
            komut.Parameters.AddWithValue("@TelNo", textBox8.Text);
            cn.Open();
            komut.ExecuteNonQuery();
            cn.Close();
            görüntüleme();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Müşteribilgi WHERE Ad LIKE '%" + textBox9.Text + "%'", cn);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            cn.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           

           
        }
    }
}
