namespace AD
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lisa_kat = new System.Windows.Forms.Button();
            this.lbl_hind = new System.Windows.Forms.Label();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.lbl_kogus = new System.Windows.Forms.Label();
            this.txt_kogus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_toode = new System.Windows.Forms.TextBox();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.kustuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(103, 351);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(766, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(103, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategooriad\r\n";
            // 
            // lisa_kat
            // 
            this.lisa_kat.Location = new System.Drawing.Point(196, 256);
            this.lisa_kat.Name = "lisa_kat";
            this.lisa_kat.Size = new System.Drawing.Size(116, 23);
            this.lisa_kat.TabIndex = 3;
            this.lisa_kat.Text = "Lisa Kategooria\r\n";
            this.lisa_kat.UseVisualStyleBackColor = true;
            this.lisa_kat.Click += new System.EventHandler(this.lisa_kat_Click);
            // 
            // lbl_hind
            // 
            this.lbl_hind.AutoSize = true;
            this.lbl_hind.Location = new System.Drawing.Point(100, 221);
            this.lbl_hind.Name = "lbl_hind";
            this.lbl_hind.Size = new System.Drawing.Size(29, 13);
            this.lbl_hind.TabIndex = 4;
            this.lbl_hind.Text = "Hind\r\n";
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(196, 218);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(116, 20);
            this.txt_box.TabIndex = 5;
            // 
            // lbl_kogus
            // 
            this.lbl_kogus.AutoSize = true;
            this.lbl_kogus.Location = new System.Drawing.Point(100, 184);
            this.lbl_kogus.Name = "lbl_kogus";
            this.lbl_kogus.Size = new System.Drawing.Size(37, 13);
            this.lbl_kogus.TabIndex = 6;
            this.lbl_kogus.Text = "Kogus";
            // 
            // txt_kogus
            // 
            this.txt_kogus.Location = new System.Drawing.Point(196, 181);
            this.txt_kogus.Name = "txt_kogus";
            this.txt_kogus.Size = new System.Drawing.Size(116, 20);
            this.txt_kogus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toode nimetus";
            // 
            // txt_toode
            // 
            this.txt_toode.Location = new System.Drawing.Point(196, 142);
            this.txt_toode.Name = "txt_toode";
            this.txt_toode.Size = new System.Drawing.Size(116, 20);
            this.txt_toode.TabIndex = 9;
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(349, 291);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(108, 23);
            this.lisa_btn.TabIndex = 10;
            this.lisa_btn.Text = "Lisa";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // kustuta
            // 
            this.kustuta.Location = new System.Drawing.Point(349, 256);
            this.kustuta.Name = "kustuta";
            this.kustuta.Size = new System.Drawing.Size(108, 23);
            this.kustuta.TabIndex = 11;
            this.kustuta.Text = "Kustuta Kategooria";
            this.kustuta.UseVisualStyleBackColor = true;
            this.kustuta.Click += new System.EventHandler(this.kustuta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.kustuta);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.txt_toode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kogus);
            this.Controls.Add(this.lbl_kogus);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.lbl_hind);
            this.Controls.Add(this.lisa_kat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lisa_kat;
        private System.Windows.Forms.Label lbl_hind;
        private System.Windows.Forms.TextBox txt_box;
        private System.Windows.Forms.Label lbl_kogus;
        private System.Windows.Forms.TextBox txt_kogus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_toode;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button kustuta;
    }
}

