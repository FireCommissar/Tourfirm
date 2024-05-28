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
    public partial class FormTourChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormTourChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadTour();
        }

        private void loadTour()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM tour", con);
            adap.Fill(dt);
            dataGridViewTour.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbName.Text = dataGridViewTour.CurrentRow.Cells[1].Value.ToString();
            this.tbPrice.Text = dataGridViewTour.CurrentRow.Cells[2].Value.ToString();
            this.tbInfo.Text = dataGridViewTour.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tour SET tour_name = @tour_name, price = @price, info = @info  WHERE tour_id = @tour_id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("tour_name", this.tbName.Text);
            cmd.Parameters.AddWithValue("price", Decimal.Parse(this.tbPrice.Text));
            cmd.Parameters.AddWithValue("info", this.tbInfo.Text);
            int id = int.Parse(dataGridViewTour.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("tour_id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            
            loadTour();
        }
    }
}
