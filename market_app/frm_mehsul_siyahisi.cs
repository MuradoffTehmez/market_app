using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace market_app
{
    public partial class frm_mehsul_siyahisi : Form
    {
        public frm_mehsul_siyahisi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        DataSet datasd = new DataSet();
        private void kateqoriya_goster()
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("select *from kateqoriya", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                combo_Kateqoriya.Items.Add(read["kateqoriya"].ToString());
            }
            con.Close();
        }
        private void frm_mehsul_siyahisi_Load(object sender, EventArgs e)
        {
            mehsul_yenile();
            kateqoriya_goster();
            txt_barkod_axtarma_meni_sen_cani.Focus();
        }

        private void mehsul_yenile()
        {
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from mehsullar", con);
            adap.Fill(datasd, "mehsullar");
            dataGridView1.DataSource = datasd.Tables["mehsullar"];
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable taple = new DataTable();
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from mehsullar where barkodno like'%" + txt_barkod_axtarma_meni_sen_cani.Text + "%'", con);
            adap.Fill(taple);
            dataGridView1.DataSource = taple;
            con.Close();
        }

        private void Btn_deyisdir_Click(object sender, EventArgs e)
        {
            //if ()
            {

                con.Open();
                SqlCommand sqlCommand = new SqlCommand("update mehsullar set miqdari=@miqdari,melsuladi=@melsuladi,alisqiymeti=@alisqiymeti,satisqiymeti=@satisqiymeti where barkodno=@barkodno ", con);
                sqlCommand.Parameters.AddWithValue("@barkodno", var_txt_barkod.Text);
                sqlCommand.Parameters.AddWithValue("@melsuladi", var_txt_mehsul_adi.Text);
                sqlCommand.Parameters.AddWithValue("@miqdari", int.Parse(var_txt_miqdari.Text));
                sqlCommand.Parameters.AddWithValue("@alisqiymeti", double.Parse(var_txt_alis_qiymeti.Text));
                sqlCommand.Parameters.AddWithValue("@satisqiymeti", double.Parse(var_txt_satis_qiymeti.Text));
                sqlCommand.ExecuteNonQuery();
                con.Close();
                datasd.Tables["mehsullar"].Clear();
                mehsul_yenile();
                MessageBox.Show("Mehsullar yenilendi", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var_txt_barkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            var_txt_katekoriya.Text = dataGridView1.CurrentRow.Cells["katekori"].Value.ToString();
            var_txt_marka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            var_txt_mehsul_adi.Text = dataGridView1.CurrentRow.Cells["melsuladi"].Value.ToString();
            var_txt_miqdari.Text = dataGridView1.CurrentRow.Cells["miqdari"].Value.ToString();
            var_txt_alis_qiymeti.Text = dataGridView1.CurrentRow.Cells["alisqiymeti"].Value.ToString();
            var_txt_satis_qiymeti.Text = dataGridView1.CurrentRow.Cells["satisqiymeti"].Value.ToString();
        }

        private void Btn_marka_guncel_Click(object sender, EventArgs e)
        {
            if (var_txt_barkod.Text != "")
            {

                con.Open();
                SqlCommand sqlCommand = new SqlCommand("update mehsullar set katekori=@katekori,marka=@marka where barkodno=@barkodno ", con);
                sqlCommand.Parameters.AddWithValue("@barkodno", var_txt_barkod.Text);
                sqlCommand.Parameters.AddWithValue("@katekori", combo_Kateqoriya.Text);
                sqlCommand.Parameters.AddWithValue("@marka", combo_Marka.Text);

                sqlCommand.ExecuteNonQuery();
                con.Close();
                datasd.Tables["mehsullar"].Clear();
                mehsul_yenile();
                MessageBox.Show("Mehsullar yenilendi", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Barkod Sutunu secili deyil !", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void combo_Kateqoriya_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Marka.Items.Clear();
            combo_Marka.Text = "";
            con.Open();
            SqlCommand mttm = new SqlCommand("select * from marka where kateqoriya='" + combo_Kateqoriya.SelectedItem + "'", con);
            SqlDataReader read = mttm.ExecuteReader();
            while (read.Read())
            {
                combo_Marka.Items.Add(read["marka"].ToString());
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("delete from mehsullar where barkodno= '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", con);
            mttm.ExecuteNonQuery();
            con.Close();
            datasd.Tables["mehsullar"].Clear();
            mehsul_yenile();
            MessageBox.Show("Silindi", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
