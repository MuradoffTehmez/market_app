using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace market_app
{
    public partial class frm_musteri_siyahi : Form
    {
        public frm_musteri_siyahi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        DataSet datas = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("delete from musteri where personal= '" + dataGridView1.CurrentRow.Cells["personal"].Value.ToString()+"'",con);
            mttm.ExecuteNonQuery();
            con.Close();
            datas.Tables["musteri"].Clear();
            qeyd_goster();
            MessageBox.Show("Silindi", "DIQQET", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable taple = new DataTable();
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from musteri where personal like'%" + txt_axtarma_meni.Text + "%'", con);
            adap.Fill(taple);
            dataGridView1.DataSource = taple;
            con.Close();
        }

        private void frm_musteri_siyahi_Load(object sender, EventArgs e)
        {
            qeyd_goster();
        }

        private void qeyd_goster()
        {
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from musteri", con);
            adap.Fill(datas, "musteri");
            dataGridView1.DataSource = datas.Tables["musteri"];
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells["personal"].Value.ToString();
            txt_ad_soyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txt_telefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txt_adress.Text = dataGridView1.CurrentRow.Cells["adress"].Value.ToString();
            txt_e_mail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_elve_et_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("update musteri set adsoyad=@adsoyad,telefon=@telefon,adress=adress,email=@email where personal=@personal", con);
            mttm.Parameters.AddWithValue("@personal", txt_id.Text);
            mttm.Parameters.AddWithValue("@adsoyad", txt_ad_soyad.Text);
            mttm.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            mttm.Parameters.AddWithValue("@adress", txt_adress.Text);
            mttm.Parameters.AddWithValue("@email", txt_e_mail.Text);
            mttm.ExecuteNonQuery();
            con.Close();
            datas.Tables["musteri"].Clear();
            qeyd_goster();
            MessageBox.Show("Melumatlar Yenilendi", "DIQQET", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
