using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace market_app
{
    public partial class frm_katakoriya : Form
    {
        public frm_katakoriya()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        bool netice;

        private void kateqoriya_blok()
        {
            netice = true;
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from kateqoriya", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kateqoriya"].ToString() || textBox1.Text == "")
                {
                    netice = false;
                }
            }

            con.Close();
        }

        private void frm_katakoriya_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kateqoriya_blok();
            if (netice == true && textBox1.Text != "")
            {
                
                con.Open();
                SqlCommand mttm = new SqlCommand("insert into kateqoriya(kateqoriya) values('" + textBox1.Text + "')", con);
                mttm.ExecuteNonQuery();
                con.Close();
       
                MessageBox.Show("kateqoriya Əlavə olundu", "DİQQƏT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" bu kateqoriya var", "DİQQƏT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
        }
    }
}
