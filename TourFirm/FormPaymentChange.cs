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
    public partial class FormPaymentChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormPaymentChange()
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
                comboBoxVoucher.Items.Add((reader.GetValue(0).ToString()));
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

        private void dataGridViewPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int t_index = comboBoxTourist.FindString(dataGridViewVoucher.CurrentRow.Cells[1].Value.ToString());
            //comboBoxTourist.SelectedIndex = t_index;
            this.comboBoxVoucher.SelectedItem = dataGridViewPayment.CurrentRow.Cells[1].Value.ToString();
            this.datePayment.Text = dataGridViewPayment.CurrentRow.Cells[2].Value.ToString();
            this.tbDeposit.Text = dataGridViewPayment.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE payment SET voucher_id = @voucher_id, pay_date = @pay_date, deposit = @deposit  WHERE payment_id = @payment_id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("voucher_id", int.Parse(comboBoxVoucher.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("pay_date", datePayment.Value);
            cmd.Parameters.AddWithValue("deposit", Decimal.Parse(tbDeposit.Text.ToString()));
            int id = int.Parse(dataGridViewPayment.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("payment_id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadPayment();

            this.comboBoxVoucher.Text = "";
            this.datePayment.Text = "";
            this.tbDeposit.Text = "";
        }
    }
}
