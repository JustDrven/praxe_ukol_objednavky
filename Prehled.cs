/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        Prehled.cs
 * Author:      JustDrven
 * 
 *******************************************/

using Microsoft.Data.SqlClient;
using praxe_desktop_client.Db;
using praxe_desktop_client.Utilities;
using System.Data;

namespace praxe_desktop_client
{
    public partial class Prehled : Form
    {


        public Prehled()
        {
            InitializeComponent();


            UtilWindow.DisableResizeable(this);
            UtilWindow.SetTitle(this, "Historie objednávek");

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            var jmeno = JmInput.Text.Trim();
            if (string.IsNullOrEmpty(jmeno)) return; 
            var prijmeni = PrInput.Text.Trim();
            if (string.IsNullOrEmpty(prijmeni)) return;


            using (SqlConnection conn = DatabaseFactory.CreateConnection("Objednavky"))
            {
                SqlDataAdapter adp = new SqlDataAdapter(
                     "SELECT * FROM praxe_objednavka WHERE jmeno = @Jm AND prijmeni = @Pr", conn
                );

                adp.SelectCommand.Parameters.Add("@Jm", SqlDbType.NVarChar, 50).Value = jmeno;
                adp.SelectCommand.Parameters.Add("@Pr", SqlDbType.NVarChar, 50).Value = prijmeni;

                DataTable dt = new DataTable();
                adp.Fill(dt);

                PrehledVysledky.AutoGenerateColumns = true;
                PrehledVysledky.DataSource = dt;

            }


        }

      
        private void PrehledVysledky_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var index = e.RowIndex;


            UtilList.SetContent(PrehledPolozky, () =>
            {
                var items = PrehledPolozky.Items;


                var information = PrehledVysledky.Rows[index];


                var id = information.Cells[0].Value;
                var jmeno = information.Cells[1].Value;
                var prijmeni = information.Cells[2].Value;
                var datum = information.Cells[3].Value;
                var hodnota = information.Cells[4].Value;
                var polozka = information.Cells[5].Value;

                PrehledId.Text = "ID: " + id;
                PrehledJmenoAPrijmeni.Text = "Jméno a Příjmení: " + jmeno + " " + prijmeni;
                PrehledDatum.Text = "Datum: " + datum;
                PrehledHodnota.Text = "Hodnota: " + hodnota;


                if (polozka == null) return;
                string[] polozky = polozka.ToString().Split(";");

                if (polozky != null && polozky.Length != 0)
                {
                    foreach (var p in polozky)
                    {
                        items.Add(p.Trim());
                    }
                }
               


            });

        }
    }
}
