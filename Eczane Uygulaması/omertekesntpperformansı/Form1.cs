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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OBHBBQ7;Initial Catalog=eczaneNTP;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand komut;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from kullanicigiris WHERE kullaniciadi = @kullaniciadi And sifre = @sifre";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            
            cn.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 form3 = new Form3(); 
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yada şifreniz hatalı !");
            }
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from admin WHERE kullaniciadi = @kullaniciadi And sifre = @sifre";
            komut = new SqlCommand(sorgu, cn);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);

            cn.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yada şifreniz hatalı !");
            }
            cn.Close();
        }
    }
}
