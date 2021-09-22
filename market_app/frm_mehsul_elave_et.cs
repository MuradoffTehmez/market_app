using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace market_app
{
    public partial class frm_mehsul_elave_et : Form
    {
        public frm_mehsul_elave_et()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        bool netice;

        private void barkod_blok()
        {
            netice = true;
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from mehsullar", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                if (txt_barkod_no.Text == read["barkodno"].ToString()  ||  txt_barkod_no.Text=="")
                {
                    netice = false;
                }
            }

            con.Close();
        }

        private void kateqoriya_goster()
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("select *from kateqoriya", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                combo_kateqoriya.Items.Add(read["kateqoriya"].ToString());
            }
            con.Close();
        }
        private void frm_mehsul_elave_et_Load(object sender, EventArgs e)
        {
             kateqoriya_goster();
        }

        private void combo_kateqoriya_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_marka.Items.Clear();
            combo_marka.Text = "";
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from marka where kateqoriya='"+combo_kateqoriya.SelectedItem+"'", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                combo_marka.Items.Add(read["marka"].ToString());
            }
            con.Close();
        }

        private void btn_yeni_elave_et_Click(object sender, EventArgs e)
        {
            barkod_blok();
            if (netice == true)
            {

                con.Open();
                SqlCommand mttm = new SqlCommand("insert into mehsullar(barkodno,katekori,marka,melsuladi,miqdari,alisqiymeti,satisqiymeti,tarix) values(@barkodno,@katekori,@marka,@melsuladi,@miqdari,@alisqiymeti,@satisqiymeti,@tarix)", con);
                mttm.Parameters.AddWithValue("@barkodno", txt_barkod_no.Text);
                mttm.Parameters.AddWithValue("@katekori", combo_kateqoriya.Text);
                mttm.Parameters.AddWithValue("@marka", combo_marka.Text);
                mttm.Parameters.AddWithValue("@melsuladi", txt_mehsuladi.Text);
                mttm.Parameters.AddWithValue("@miqdari", int.Parse(txt_miqdar.Text));
                mttm.Parameters.AddWithValue("@alisqiymeti", double.Parse(txt_alis_qiymet.Text));
                mttm.Parameters.AddWithValue("@satisqiymeti", double.Parse(txt_satis_qiymet.Text));
                mttm.Parameters.AddWithValue("@tarix", DateTime.Now.ToString());
                mttm.ExecuteNonQuery();
                con.Close();             
                MessageBox.Show("Mehsul elave edildi", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
               /*foreach (Control item in list1.Controls)
                 {
                     if (item is TextBox)

                     {
                         item.Text = "";
                     }
                     if (item is ComboBox)
                     {
                         item.Text = "";
                     }
                 }
                */
            }
            else
            {
                MessageBox.Show("Bu Barkod Movcuttur", "DİQQƏT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            combo_marka.Text = "";
            txt_barkod_no.Text = "";
            combo_kateqoriya.Text = "";
            txt_mehsuladi.Text = "";
            txt_miqdar.Text = "";
            txt_alis_qiymet.Text = "";
            txt_satis_qiymet.Text = "";
            combo_marka.Items.Clear();
        }

        private void var_txt_barkod_TextChanged(object sender, EventArgs e)
        {
            if (var_txt_barkod.Text=="")
            {
                lbl_miqdar.Text = "";
                foreach (Control item in list2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from mehsullar where barkodno like '"+var_txt_barkod.Text+"' ", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                var_txt_katekoriya.Text = read["katekori"].ToString();
                var_txt_marka.Text = read["marka"].ToString();
                var_txt_mehsul_adi.Text = read["melsuladi"].ToString();
                lbl_miqdar.Text = read["miqdari"].ToString();
                var_txt_alis_qiymeti.Text = read["alisqiymeti"].ToString();
                var_txt_satis_qiymeti.Text = read["satisqiymeti"].ToString();
            }
            con.Close();
        }

        private void btn_var_olana_elave_et_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("update mehsullar set miqdari=miqdari+'" + int.Parse(var_txt_miqdari.Text) + "'where barkodno='" + var_txt_barkod.Text + "'", con);
            mttm.ExecuteNonQuery();
            con.Close();
            foreach (Control item in list2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Anbarda deyisiklik edildi", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
