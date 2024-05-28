using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourFirm
{
    public partial class FormSeasonAdd : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormSeasonAdd()
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
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM season", con);
            adap.Fill(dt);
            dataGridViewSeason.DataSource = dt;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tour_id, tour_name FROM tour";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int tour_id = 0;
            while (reader.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (comboBoxTour.SelectedItem.ToString() == reader.GetString(1) )
                {
                    tour_id = Convert.ToInt32(reader.GetValue(0));
                }
            }
            reader.Close();

            string sql1 = "INSERT INTO season(tour_id, start_date, end_date, season_is_closed, number_of_places) VALUES(@tour_id, @start_date, @end_date, @season_is_closed, @number_of_places)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("tour_id", tour_id);
            cmd1.Parameters.AddWithValue("start_date", this.dateStart.Value);
            cmd1.Parameters.AddWithValue("end_date", this.dateEnd.Value);
            cmd1.Parameters.AddWithValue("season_is_closed", this.checkBox1.Checked);
            cmd1.Parameters.AddWithValue("number_of_places", int.Parse(this.tbNumPlaces.Text));



            cmd1.Prepare();

            cmd1.ExecuteNonQuery();
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

        private void FormSeasonAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
