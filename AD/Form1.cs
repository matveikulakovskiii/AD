using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;








namespace AD
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\opilane\Source\Repos\Matvei Kulakovski\AD\AD\AppData\tooded_DB.mdf"";Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand comand;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooriad();
        }

        public void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria= new SqlDataAdapter("SELECT Kategooria_nimetus FROM KategooriaTable", connect);
            DataTable dt_Kategooria = new DataTable();
            adapter_kategooria.Fill(dt_Kategooria);
            foreach (DataRow item in dt_Kategooria.Rows)
            {
                comboBox2.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();
        }

        private void lisa_kat_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in comboBox2.Items)
                if (item.ToString() == comboBox2.Text)
                {
                    on = true;
                }
            if(on == false)
            {
                comand = new SqlCommand("INSERT INTO KategooriaTable (Kategooria_nimetus) VALUES (@Kat)", connect);
                connect.Open();
                comand.Parameters.AddWithValue("@Kat", comboBox2.Text);
                comand.ExecuteNonQuery();
                connect.Close();
                comboBox2.Items.Clear();
                NaitaKategooriad();
            }
        }

        

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT ToodeTabel.Id, Toodenimetus, Kogus, Hind, Pilt, Kategooria_nimetus FROM ToodeTabel INNER JOIN KategooriaTable on ToodeTabel.Kategooriad=KategooriaTable.Id", connect);
            adapter_toode.Fill(dt_Toode);
            dataGridView2.DataSource = dt_Toode;
            DataGridViewComboBoxColumn dgvcb = new DataGridViewComboBoxColumn();
            dgvcb.HeaderText = "Kategooria";
            dgvcb.Name = "KategooriaColumn";
            dgvcb.DataPropertyName = "Kategooria";
            foreach (DataRow item in dt_Toode.Rows)
            {
                string category = item["Kategooria_nimetus"].ToString();
                if (!dgvcb.Items.Contains(item["Kategooria_nimetus"]))
                    dgvcb.Items.Add(item["Kategooria_nimetus"]);
            }
            
            dataGridView2.Columns.Add(dgvcb);
            
            connect.Close();
        }
        int Id = 0;
        public void lisa_btn_Click(object sender, EventArgs e)
        {
            if (txt_toode.Text.Trim()!=string.Empty && txt_kogus.Text.Trim()!=string.Empty && txt_box.Text.Trim()!=string.Empty && comboBox2.SelectedItem!=null)
            {
                try
                {
                    connect.Open();
                    comand = new SqlCommand("SELECT Id FROM KategooriaTable WHERE Kategooria_nimetus=@kat", connect);
                    comand.Parameters.AddWithValue("@kat", comboBox2.Text);
                    comand.ExecuteNonQuery();
                    int Id = Convert.ToInt32(comand.ExecuteScalar());

                    comand = new SqlCommand("INSERT INTO ToodeTabel (Toodenimetus, Kogus, Hind, Pilt, Kategooriad) VALUES(@toode, @kogus, @hind, @pilt, @kat)", connect);
                    comand.Parameters.AddWithValue("@toode", txt_toode.Text);
                    comand.Parameters.AddWithValue("@kogus", txt_kogus.Text);
                    comand.Parameters.AddWithValue("@hind", txt_box.Text);
                    comand.Parameters.AddWithValue("@pilt", txt_toode.Text + extension);
                    comand.Parameters.AddWithValue("@kat", Id);//id
                    comand.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmed");
            }
        }

        private void kustuta_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string val_kat = comboBox2.SelectedItem.ToString();
                comand = new SqlCommand("DELETE FROM KategooriaTable WHERE Kategooria_nimetus = @Kat", connect);
                connect.Open();
                comand.Parameters.AddWithValue("@Kat", val_kat);
                comand.ExecuteNonQuery();
                connect.Close();
                comboBox2.Items.Clear();
                NaitaKategooriad();
            }
        }

        SaveFileDialog save;
        OpenFileDialog open;
        string extension = null;
        private void btn_pilt_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Source\Repos\Matvei Kulakovski\AD\AD\fotos";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jeg; *.bmp; *.png; *.jpg)|*.jeg; *.bmp; *.png; *.jpg";

            //FileInfo open_file = new FileInfo(@"C:\Users\opilane\Source\Repos\Matvei Kulakovski\AD\AD\fotos" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && txt_toode.Text!=null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\..\fotos");
                extension = Path.GetExtension(open.FileName);
                save.FileName = txt_toode.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName)+"|"+Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && txt_toode.Text != null)
                {
                    File.Copy(open.FileName,save.FileName);
                    pb1.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud Cancel");
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView2.Rows[e.RowIndex].Cells["id"].Value;
            txt_toode.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_kogus.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_box.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            try 
            {
                pb1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\fotos"), dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Pilt puudub");
            }
            comboBox2.SelectedItem = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void kst_btn_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string val_kat = comboBox2.SelectedItem.ToString();
                comand = new SqlCommand("DELETE FROM ToodeTabel WHERE Toodenimetus = @toode, Kogus = @kogus, Hind = @hind, Pilt = @pilt, Kategooriad = @kat)", connect);
                connect.Open();
                comand.Parameters.AddWithValue("@Kat", val_kat);
                comand.ExecuteNonQuery();
                connect.Close();
                comboBox2.Items.Clear();
                NaitaKategooriad();
            }
        }

        public void NaitaHind()
        {
            connect.Open();
            adapter_toode = new SqlDataAdapter("SELECT Hind FROM ToodeTabel", connect);

            connect.Close();
        }
    }
}
