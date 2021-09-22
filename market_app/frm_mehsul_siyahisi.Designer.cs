namespace market_app
{
    partial class frm_mehsul_siyahisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mehsul_siyahisi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_deyisdir = new System.Windows.Forms.Button();
            this.var_txt_satis_qiymeti = new System.Windows.Forms.TextBox();
            this.var_txt_alis_qiymeti = new System.Windows.Forms.TextBox();
            this.var_txt_miqdari = new System.Windows.Forms.TextBox();
            this.var_txt_mehsul_adi = new System.Windows.Forms.TextBox();
            this.var_txt_marka = new System.Windows.Forms.TextBox();
            this.var_txt_katekoriya = new System.Windows.Forms.TextBox();
            this.var_txt_barkod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_barkod_axtarma_meni_sen_cani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_marka_guncel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Marka = new System.Windows.Forms.ComboBox();
            this.combo_Kateqoriya = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1169, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(922, 531);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Satış Qiyməti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Alış Qiyməti";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Miqdarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 19);
            this.label11.TabIndex = 33;
            this.label11.Text = "Məhsul Adi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kateqoriya";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "Barkod";
            // 
            // Btn_deyisdir
            // 
            this.Btn_deyisdir.BackColor = System.Drawing.Color.Gold;
            this.Btn_deyisdir.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Btn_deyisdir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.Btn_deyisdir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_deyisdir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_deyisdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_deyisdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_deyisdir.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_deyisdir.Location = new System.Drawing.Point(119, 297);
            this.Btn_deyisdir.Name = "Btn_deyisdir";
            this.Btn_deyisdir.Size = new System.Drawing.Size(146, 31);
            this.Btn_deyisdir.TabIndex = 29;
            this.Btn_deyisdir.Text = "Guncelle";
            this.Btn_deyisdir.UseVisualStyleBackColor = false;
            this.Btn_deyisdir.Click += new System.EventHandler(this.Btn_deyisdir_Click);
            // 
            // var_txt_satis_qiymeti
            // 
            this.var_txt_satis_qiymeti.Location = new System.Drawing.Point(119, 264);
            this.var_txt_satis_qiymeti.Name = "var_txt_satis_qiymeti";
            this.var_txt_satis_qiymeti.Size = new System.Drawing.Size(146, 27);
            this.var_txt_satis_qiymeti.TabIndex = 28;
            // 
            // var_txt_alis_qiymeti
            // 
            this.var_txt_alis_qiymeti.Location = new System.Drawing.Point(119, 229);
            this.var_txt_alis_qiymeti.Name = "var_txt_alis_qiymeti";
            this.var_txt_alis_qiymeti.Size = new System.Drawing.Size(146, 27);
            this.var_txt_alis_qiymeti.TabIndex = 27;
            // 
            // var_txt_miqdari
            // 
            this.var_txt_miqdari.Location = new System.Drawing.Point(119, 194);
            this.var_txt_miqdari.Name = "var_txt_miqdari";
            this.var_txt_miqdari.Size = new System.Drawing.Size(146, 27);
            this.var_txt_miqdari.TabIndex = 26;
            // 
            // var_txt_mehsul_adi
            // 
            this.var_txt_mehsul_adi.Location = new System.Drawing.Point(119, 159);
            this.var_txt_mehsul_adi.Name = "var_txt_mehsul_adi";
            this.var_txt_mehsul_adi.Size = new System.Drawing.Size(146, 27);
            this.var_txt_mehsul_adi.TabIndex = 25;
            // 
            // var_txt_marka
            // 
            this.var_txt_marka.Location = new System.Drawing.Point(119, 124);
            this.var_txt_marka.Name = "var_txt_marka";
            this.var_txt_marka.ReadOnly = true;
            this.var_txt_marka.Size = new System.Drawing.Size(146, 27);
            this.var_txt_marka.TabIndex = 24;
            // 
            // var_txt_katekoriya
            // 
            this.var_txt_katekoriya.Location = new System.Drawing.Point(119, 89);
            this.var_txt_katekoriya.Name = "var_txt_katekoriya";
            this.var_txt_katekoriya.ReadOnly = true;
            this.var_txt_katekoriya.Size = new System.Drawing.Size(146, 27);
            this.var_txt_katekoriya.TabIndex = 23;
            // 
            // var_txt_barkod
            // 
            this.var_txt_barkod.Location = new System.Drawing.Point(119, 54);
            this.var_txt_barkod.Name = "var_txt_barkod";
            this.var_txt_barkod.Size = new System.Drawing.Size(146, 27);
            this.var_txt_barkod.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.var_txt_miqdari);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.var_txt_barkod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.var_txt_katekoriya);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.var_txt_marka);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.var_txt_mehsul_adi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.var_txt_alis_qiymeti);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.var_txt_satis_qiymeti);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Btn_deyisdir);
            this.groupBox1.Location = new System.Drawing.Point(0, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 353);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Location = new System.Drawing.Point(1106, 49);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(90, 29);
            this.btn_sil.TabIndex = 38;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_barkod_axtarma_meni_sen_cani
            // 
            this.txt_barkod_axtarma_meni_sen_cani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_barkod_axtarma_meni_sen_cani.BackColor = System.Drawing.Color.Cyan;
            this.txt_barkod_axtarma_meni_sen_cani.Location = new System.Drawing.Point(467, 16);
            this.txt_barkod_axtarma_meni_sen_cani.Name = "txt_barkod_axtarma_meni_sen_cani";
            this.txt_barkod_axtarma_meni_sen_cani.Size = new System.Drawing.Size(578, 27);
            this.txt_barkod_axtarma_meni_sen_cani.TabIndex = 39;
            this.txt_barkod_axtarma_meni_sen_cani.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkoda Gore Axtar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.LawnGreen;
            this.groupBox2.Controls.Add(this.Btn_marka_guncel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_Marka);
            this.groupBox2.Controls.Add(this.combo_Kateqoriya);
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 283);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // Btn_marka_guncel
            // 
            this.Btn_marka_guncel.BackColor = System.Drawing.Color.Gold;
            this.Btn_marka_guncel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Btn_marka_guncel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.Btn_marka_guncel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_marka_guncel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_marka_guncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_marka_guncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_marka_guncel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_marka_guncel.Location = new System.Drawing.Point(104, 167);
            this.Btn_marka_guncel.Name = "Btn_marka_guncel";
            this.Btn_marka_guncel.Size = new System.Drawing.Size(146, 31);
            this.Btn_marka_guncel.TabIndex = 37;
            this.Btn_marka_guncel.Text = "Guncelle";
            this.Btn_marka_guncel.UseVisualStyleBackColor = false;
            this.Btn_marka_guncel.Click += new System.EventHandler(this.Btn_marka_guncel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kateqoriya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Marka";
            // 
            // combo_Marka
            // 
            this.combo_Marka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Marka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Marka.ForeColor = System.Drawing.Color.Red;
            this.combo_Marka.FormattingEnabled = true;
            this.combo_Marka.Location = new System.Drawing.Point(14, 123);
            this.combo_Marka.Name = "combo_Marka";
            this.combo_Marka.Size = new System.Drawing.Size(236, 27);
            this.combo_Marka.TabIndex = 1;
            // 
            // combo_Kateqoriya
            // 
            this.combo_Kateqoriya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Kateqoriya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Kateqoriya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Kateqoriya.ForeColor = System.Drawing.Color.Red;
            this.combo_Kateqoriya.FormattingEnabled = true;
            this.combo_Kateqoriya.Location = new System.Drawing.Point(14, 59);
            this.combo_Kateqoriya.Name = "combo_Kateqoriya";
            this.combo_Kateqoriya.Size = new System.Drawing.Size(236, 27);
            this.combo_Kateqoriya.TabIndex = 0;
            this.combo_Kateqoriya.SelectedIndexChanged += new System.EventHandler(this.combo_Kateqoriya_SelectedIndexChanged);
            // 
            // frm_mehsul_siyahisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1197, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barkod_axtarma_meni_sen_cani);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_mehsul_siyahisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_mehsul_siyahisi";
            this.Load += new System.EventHandler(this.frm_mehsul_siyahisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btn_deyisdir;
        private System.Windows.Forms.TextBox var_txt_satis_qiymeti;
        private System.Windows.Forms.TextBox var_txt_alis_qiymeti;
        private System.Windows.Forms.TextBox var_txt_miqdari;
        private System.Windows.Forms.TextBox var_txt_mehsul_adi;
        private System.Windows.Forms.TextBox var_txt_marka;
        private System.Windows.Forms.TextBox var_txt_katekoriya;
        private System.Windows.Forms.TextBox var_txt_barkod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_barkod_axtarma_meni_sen_cani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_Marka;
        private System.Windows.Forms.ComboBox combo_Kateqoriya;
        private System.Windows.Forms.Button Btn_marka_guncel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}