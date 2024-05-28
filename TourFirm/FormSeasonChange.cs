using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TourFirm
{
    public partial class FormSeasonChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormSeasonChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadSeason();

            string sql = "SELECT tour_name FROM tour";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            comboBoxTour.Items.Clear();
            while (reader.Read())
            {
                comboBoxTour.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void loadSeason()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT  * FROM season", con);
            adap.Fill(dt);
            dataGridViewSeason.DataSource = dt;
        }

        private void dataGridViewSeason_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbLastname.Text = dataGridViewTourist.SelectedCells[1].Value.ToString();
            //tbName.Text = dataGridViewTourist.CurrentRow.Cells[2].Value.ToString();
            //tbSurname.Text = dataGridViewTourist.CurrentRow.Cells[3].Value.ToString();
            //tbPass.Text = dataGridViewTourist.CurrentRow.Cells[4].Value.ToString();
            //tbCity.Text = dataGridViewTourist.CurrentRow.Cells[5].Value.ToString();
            //tbCountry.Text = dataGridViewTourist.CurrentRow.Cells[6].Value.ToString();
            //tbPhoneNumber.Text = dataGridViewTourist.CurrentRow.Cells[7].Value.ToString();
            //tbIndex.Text = dataGridViewTourist.CurrentRow.Cells[8].Value.ToString();

            string sql = "SELECT tour_id, tour_name FROM tour";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            string tour_name = "";
            while (reader.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (Convert.ToInt32(dataGridViewSeason.CurrentRow.Cells[1].Value) == Convert.ToInt32(reader.GetValue(0)))
                {
                    tour_name = reader.GetString(1);
                }
            }
            reader.Close();

            comboBoxTour.SelectedItem = tour_name;
            dateStart.Text = dataGridViewSeason.CurrentRow.Cells[2].Value.ToString();
            dateEnd.Text = dataGridViewSeason.CurrentRow.Cells[3].Value.ToString();
            //if ((bool)dataGridViewSeason.CurrentRow.Cells[4].Value == true)
            //{
            //    checkBox1.Checked = true;
            //}
            //else { checkBox1.Checked = false; }
            checkBox1.Checked = (bool)dataGridViewSeason.CurrentRow.Cells[4].Value;
            tbNumPlaces.Text = dataGridViewSeason.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT tour_id, tour_name FROM tour";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader = cmd1.ExecuteReader();
            int tour_id = 0;
            while (reader.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (comboBoxTour.SelectedItem.ToString() == reader.GetString(1))
                {
                    tour_id = Convert.ToInt32(reader.GetValue(0));
                }
            }
            reader.Close();



            string sql = "UPDATE season SET tour_id = @tour_id , start_date = @start_date, end_date = @end_date, season_is_closed = @season_is_closed, number_of_places = @number_of_places  WHERE season_id = @season_id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("tour_id", tour_id);
            cmd.Parameters.AddWithValue("start_date", this.dateStart.Value);
            cmd.Parameters.AddWithValue("end_date", this.dateEnd.Value);
            cmd.Parameters.AddWithValue("season_is_closed", this.checkBox1.Checked);
            cmd.Parameters.AddWithValue("number_of_places", int.Parse(this.tbNumPlaces.Text));

            int id = int.Parse(dataGridViewSeason.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("season_id", id);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            loadSeason();



            this.comboBoxTour.Text = "";
            this.dateStart.Text = "";
            this.dateEnd.Text = "";
            this.checkBox1.Checked = false;
            this.tbNumPlaces.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
