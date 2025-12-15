/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        Form1.cs
 * Author:      JustDrven
 * 
 *******************************************/

using Microsoft.Data.SqlClient;
using praxe_desktop_client.Db;
using praxe_desktop_client.Utilities;
using System.Data;

namespace praxe_desktop_client
{
    public partial class Form1 : Form
    {



    
        public Form1()
        {
            InitializeComponent();

            UtilWindow.DisableResizeable(this);
            UtilWindow.SetTitle(this, "Objednávky");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView1.MultiSelect = false;
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            using (SqlConnection conn = DatabaseFactory.CreateConnection("Produkty"))
            {
                SqlDataAdapter adp = new SqlDataAdapter(
                    "SELECT DISTINCT Komodita FROM Ceny", conn);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                ListBox1.DataSource = dt;
                ListBox1.DisplayMember = "Komodita";
                ListBox1.ValueMember = "Komodita";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = DatabaseFactory.CreateConnection("Produkty"))
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = conn;
                sql.CommandType = CommandType.StoredProcedure;

                if (VyberPodleCenyBtn.Checked)
                {
                    sql.CommandText = "VyberCena";
                    sql.Parameters.Add("@Od", SqlDbType.Money).Value = int.Parse(OdInput.Text);
                    sql.Parameters.Add("@Do", SqlDbType.Money).Value = int.Parse(DoInput.Text);

                    SqlDataAdapter adp = new SqlDataAdapter(sql);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    GridView1.DataSource = dt;
                }

                if (VyberPodleKomodyBtn.Checked)
                {
                    sql.CommandText = "VyberKomodita";
                    sql.Parameters.Add("@Kom", SqlDbType.NVarChar)
                       .Value = ListBox1.SelectedValue.ToString();

                    SqlDataAdapter adp = new SqlDataAdapter(sql);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    GridView1.DataSource = dt;
                }

                if (VyberPodleNazvuBtn.Checked)
                {
                    sql.CommandText = "VyberNazev";
                    sql.Parameters.Add("@Naz", SqlDbType.NVarChar)
                       .Value = NazevInput.Text;

                    SqlDataAdapter adp = new SqlDataAdapter(sql);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    GridView1.DataSource = dt;
                }


            }
        }

        private void GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int index = e.RowIndex;

            kosik1.Items.Add("èíslo výrobku " + GridView1.Rows[index].Cells[2].Value);
            kosik1.Items.Add("název výrobku " + GridView1.Rows[index].Cells[3].Value);
            kosik1.Items.Add("cena výrobku " + GridView1.Rows[index].Cells[6].Value);

            kosik2.Items.Add(GridView1.Rows[index].Cells[5].Value);

            SpoctiCenu();
        }

        private void SpoctiCenu()
        {
            double celkem = 0;

            foreach (var item in kosik2.Items)
            {
                celkem += Convert.ToDouble(item);
            }

            vkr.Text = "Celková hodnota objednavky: " + celkem;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (kosik1.Items.Count == 0) return;

            using (SqlConnection conn = DatabaseFactory.CreateConnection("Objednavky"))
            {
                conn.Open();

                SqlCommand sql = new SqlCommand("VlozObjednavku", conn);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add("@Jm", SqlDbType.NVarChar).Value = JmenoInput.Text;
                sql.Parameters.Add("@Pr", SqlDbType.NVarChar).Value = PrijmeniInput.Text;
                sql.Parameters.Add("@Da", SqlDbType.DateTime).Value = DateTime.Now;
                sql.Parameters.Add("@Ho", SqlDbType.Money)
                   .Value = double.Parse(vkr.Text.Split(':')[1]);

                sql.Parameters.Add("@Po", SqlDbType.NText).Value = GetListBox();

                sql.ExecuteNonQuery();
            }

            kosik1.Items.Clear();
            kosik2.Items.Clear();
            vkr.Text = "Celková hodnota objednavky: 0";
        }

        private string GetListBox()
        {
            string polozky = "";

            foreach (var item in kosik1.Items)
                polozky += item.ToString() + "; ";

            return polozky;
        }

        private bool IsValid() => (JmenoInput.Text != "" && PrijmeniInput.Text != "");

        private void button3_Click(object sender, EventArgs e)
        {
            var prehled = new Prehled();

            prehled.ShowDialog();
        }
    }
}
