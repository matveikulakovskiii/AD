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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|AppData\DataDirectory|\tooded_DB.mdf;Integrated Security=True");
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

        private void button1_Click(object sender, EventArgs e)
        {
            comand = new SqlCommand("INSERT INTO KategooriaTable (Kategooria_nimetus) VALUES (@Kat)", connect);
            connect.Open();
            comand.Parameters.AddWithValue("@Kat", comboBox2.Text);
            comand.ExecuteNonQuery();
            connect.Close();
            comboBox2.Items.Clear();
            NaitaKategooriad();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM ToodeTabel", connect);
            adapter_toode.Fill(dt_Toode);
            dataGridView1.DataSource = dt_Toode;
            connect.Close();
        }

        public void NaitaHind()
        {
            connect.Open();
            DataTable dt_Toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Hind FROM ToodeTabel", connect);
            adapter_toode.Fill(dt_Toode);

            connect.Close();
        }
    }
}
