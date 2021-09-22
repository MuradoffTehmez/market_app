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
    public partial class Frm_giris : Form
    {
        public Frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection Can_ciyer = new SqlConnection("Data Source=MURADOFF-CODE\\MURADOFF_CODE;Initial Catalog=Market_MuradoffCode;Integrated Security=True");
        DataSet datas = new DataSet();

        private void sepet_list()
        {
            Can_ciyer.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from sepet", Can_ciyer);
            dataAdapter.Fill(datas,"sepet");
            dataGridView1.DataSource = datas.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            Can_ciyer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepet_list();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_musteri_elave_et elave = new Frm_musteri_elave_et();
            elave.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_musteri_siyahi siy = new frm_musteri_siyahi();
            siy.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_mehsul_elave_et ela = new frm_mehsul_elave_et();
            ela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_katakoriya kat = new frm_katakoriya();
            kat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_marka mar = new frm_marka();
            mar.ShowDialog();
        }

        private void btn_elave_et_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_mehsul_siyahisi a = new frm_mehsul_siyahisi();
            a.ShowDialog();
        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {
            if (Txt_id.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        
                     item.Text = "";
                        
                    }
                }
                //txt_ad.Text = "";
                
            }
            Can_ciyer.Open();
            SqlCommand command = new SqlCommand("select * from musteri where personal like '"+Txt_id.Text+"'", Can_ciyer);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txt_ad.Text = dataReader["adsoyad"].ToString();
                txt_telefon.Text = dataReader["telefon"].ToString();
            }
            Can_ciyer.Close();
        }

        private void Txt_Barkod_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Barkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txt_Miqdar)
                        {
                            item.Text = "";
                        }
                    }
                }
               
            }
            Can_ciyer.Open();
            SqlCommand command = new SqlCommand("select * from mehsullar where barkodno like '" + Txt_Barkod.Text + "'", Can_ciyer);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txt_mehsulAdi.Text = dataReader["melsuladi"].ToString();
                txt_satis_Qiymet.Text = dataReader["satisqiymeti"].ToString();
               
            }
            Can_ciyer.Close();
        }
    }
}
