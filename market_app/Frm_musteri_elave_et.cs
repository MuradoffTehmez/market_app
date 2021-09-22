using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace market_app
{
    public partial class Frm_musteri_elave_et : Form
    {
        public Frm_musteri_elave_et()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btn_elve_et_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mttm = new SqlCommand("INSERT INTO musteri(personal,adsoyad,telefon,adress,email) values(@personal,@adsoyad,@telefon,@adress,@email)", con);
            mttm.Parameters.AddWithValue("@personal", txt_id.Text);
            mttm.Parameters.AddWithValue("@adsoyad", txt_ad_soyad.Text);
            mttm.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            mttm.Parameters.AddWithValue("@adress", txt_adress.Text);
            mttm.Parameters.AddWithValue("@email", txt_e_mail.Text);
            mttm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Qeydiyyat Ugurludur", "DIQQET", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
