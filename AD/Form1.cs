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
            DataTable table = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodenimetus, Kogus, Hind, Pilt, Kategooria_nimetus FROM ToodeTabel INNER JOIN KategooriaTable on ToodeTabel.Kategooriad=KategooriaTable.Id", connect);
            adapter_toode.Fill(dt_Toode);
            table.Columns.Add("Nimetus");
            table.Columns.Add("Kogus");
            table.Columns.Add("Hind");
            table.Columns.Add("Pilt");
            DataGridViewComboBoxColumn dgvcb = new DataGridViewComboBoxColumn();
            foreach (DataRow item in dt_Toode.Rows)
            {
                if (!dgvcb.Items.Contains(item["Kategooria_nimetus"]))
                    dgvcb.Items.Add(item["Kategooria_nimetus"]);
                table.Rows.Add(item["Toodenimetus"], item["Kogus"], item["Hind"], item["Pilt"]);
            }
            dataGridView2.DataSource = dt_Toode;
            dataGridView2.DataSource = table;
            dataGridView2.Columns.Add(dgvcb);
            dataGridView2.Columns[4].HeaderText = "Kategooriad";
            connect.Close();
        }

        private void lisa_btn_Click(object sender, EventArgs e)
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
                    comand.Parameters.AddWithValue("@pilt", txt_toode.Text + ".jpg");
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

       
        public void NaitaHind()
        {
            connect.Open();
            adapter_toode = new SqlDataAdapter("SELECT Hind FROM ToodeTabel", connect);

            connect.Close();
        }
    }
}
