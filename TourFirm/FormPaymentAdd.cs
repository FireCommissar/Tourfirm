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
    public partial class FormPaymentAdd : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormPaymentAdd()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadPayment();

            string sql = "SELECT voucher_id FROM voucher";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            comboBoxVoucher.Items.Clear();
            while (reader.Read())
            {
                comboBoxVoucher.Items.Add(int.Parse(reader.GetValue(0).ToString()));
            }
            reader.Close();
        }

        private void loadPayment()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM payment", con);
            adap.Fill(dt);
            dataGridViewPayment.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT tour_id, tour_name FROM tour";
            //NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            //NpgsqlDataReader reader = cmd.ExecuteReader();
            //int tour_id = 0;
            //while (reader.Read())
            //{
            //    //comboBoxTour.Items.Add(reader.GetString(0));
            //    if (comboBoxTour.SelectedItem.ToString() == reader.GetString(1))
            //    {
            //        tour_id = Convert.ToInt32(reader.GetValue(0));
            //    }
            //}
            //reader.Close();

            string sql1 = "INSERT INTO payment(voucher_id, pay_date, deposit) VALUES(@voucher_id, @pay_date, @deposit)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("voucher_id", int.Parse(this.comboBoxVoucher.SelectedItem.ToString()));
            cmd1.Parameters.AddWithValue("pay_date", this.datePayment.Value);
            cmd1.Parameters.AddWithValue("deposit", Decimal.Parse(this.tbDeposit.Text));


            cmd1.Prepare();

            cmd1.ExecuteNonQuery();
            loadPayment();

            this.comboBoxVoucher.Text = "";
            this.datePayment.Text = "";
            this.tbDeposit.Text = "";
        }
    }
}
