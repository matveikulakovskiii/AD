namespace AD
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kaart = new System.Windows.Forms.CheckBox();
            this.sise = new System.Windows.Forms.Button();
            this.nimi = new System.Windows.Forms.Label();
            this.parool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            // 
            // kaart
            // 
            this.kaart.AutoSize = true;
            this.kaart.Location = new System.Drawing.Point(352, 229);
            this.kaart.Name = "kaart";
            this.kaart.Size = new System.Drawing.Size(80, 17);
            this.kaart.TabIndex = 2;
            this.kaart.Text = "kliendikaart";
            this.kaart.UseVisualStyleBackColor = true;
            // 
            // sise
            // 
            this.sise.Location = new System.Drawing.Point(334, 287);
            this.sise.Name = "sise";
            this.sise.Size = new System.Drawing.Size(121, 47);
            this.sise.TabIndex = 3;
            this.sise.Text = "sise";
            this.sise.UseVisualStyleBackColor = true;
            this.sise.Click += new System.EventHandler(this.sise_Click);
            // 
            // nimi
            // 
            this.nimi.AutoSize = true;
            this.nimi.Location = new System.Drawing.Point(363, 71);
            this.nimi.Name = "nimi";
            this.nimi.Size = new System.Drawing.Size(69, 13);
            this.nimi.TabIndex = 4;
            this.nimi.Text = "Kasutaja nimi";
            // 
            // parool
            // 
            this.parool.AutoSize = true;
            this.parool.Location = new System.Drawing.Point(370, 141);
            this.parool.Name = "parool";
            this.parool.Size = new System.Drawing.Size(51, 13);
            this.parool.TabIndex = 5;
            this.parool.Text = "Salasõna";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 449);
            this.Controls.Add(this.parool);
            this.Controls.Add(this.nimi);
            this.Controls.Add(this.sise);
            this.Controls.Add(this.kaart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox kaart;
        private System.Windows.Forms.Button sise;
        private System.Windows.Forms.Label nimi;
        private System.Windows.Forms.Label parool;
    }
}