using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace market_app
{
    public partial class frm_marka : Form
    {
        public frm_marka()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");

        bool netice;

        private void marka_blok()
        {
            netice = true;
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from marka", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["kateqoriya"].ToString() && textBox1.Text == read["marka"].ToString() || textBox1.Text == "" || comboBox1.Text == "")
                {
                    netice = false;
                }
            }

            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marka_blok();
            if (netice == true)
            {
                con.Open();
                SqlCommand mttm = new SqlCommand("insert into marka(kateqoriya,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", con);
                mttm.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Marka Əlavə olundu", "DİQQƏT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" bu kateqoriya ve marka var", "DİQQƏT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            comboBox1.Text = "";
        }

        private void frm_marka_Load(object sender, EventArgs e)
        {
            kateqoriya_goster();
            textBox1.Focus();
        }

        private void kateqoriya_goster()
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("select *from kateqoriya", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kateqoriya"].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
