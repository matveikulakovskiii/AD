namespace AD
{
    partial class Form2
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_par = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.logi = new System.Windows.Forms.Button();
            this.nimi = new System.Windows.Forms.Label();
            this.parool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(415, 125);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(198, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_par
            // 
            this.txt_par.Location = new System.Drawing.Point(415, 211);
            this.txt_par.Name = "txt_par";
            this.txt_par.Size = new System.Drawing.Size(198, 20);
            this.txt_par.TabIndex = 2;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(461, 397);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(106, 60);
            this.reg.TabIndex = 3;
            this.reg.Text = "registration";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // logi
            // 
            this.logi.Location = new System.Drawing.Point(461, 263);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(106, 50);
            this.logi.TabIndex = 4;
            this.logi.Text = "Sisse logi";
            this.logi.UseVisualStyleBackColor = true;
            this.logi.Click += new System.EventHandler(this.logi_Click);
            // 
            // nimi
            // 
            this.nimi.AutoSize = true;
            this.nimi.Location = new System.Drawing.Point(479, 82);
            this.nimi.Name = "nimi";
            this.nimi.Size = new System.Drawing.Size(69, 13);
            this.nimi.TabIndex = 5;
            this.nimi.Text = "Kasutaja nimi";
            // 
            // parool
            // 
            this.parool.AutoSize = true;
            this.parool.Location = new System.Drawing.Point(488, 179);
            this.parool.Name = "parool";
            this.parool.Size = new System.Drawing.Size(51, 13);
            this.parool.TabIndex = 6;
            this.parool.Text = "Salasõna";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 557);
            this.Controls.Add(this.parool);
            this.Controls.Add(this.nimi);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.txt_par);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_par;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button logi;
        private System.Windows.Forms.Label nimi;
        private System.Windows.Forms.Label parool;
    }
}