using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ФОРМА ДЛЯ КНОПКИ ДОБАВИТЬ ТУРИСТА + ИНФОО С ГЛАВНОЙ ФОРМЫ

namespace TourFirm
{
    public partial class FormTouristAdd : Form
    {

        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = Tourfirm";
        public FormTouristAdd()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadTourist();
        }

        private void loadTourist()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM tourist", con);
            adap.Fill(dt);
            dataGridViewTourist.DataSource = dt;
        }

        private void FormTourist_Load(object sender, EventArgs e)
        {

        }

        private void tblastname_Click(object sender, EventArgs e)
        {
            tbLastname.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tourist(lastname, name, surname) VALUES(@lastname, @name, @surname)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("lastname", this.tbLastname.Text);
            cmd.Parameters.AddWithValue("name", this.tbName.Text);
            cmd.Parameters.AddWithValue("surname", this.tbSurname.Text);
            cmd.Prepare();  

            cmd.ExecuteNonQuery();


            string sql2 = "SELECT * FROM tourist";

            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);
            NpgsqlDataReader reader = cmd2.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();
            string id1 = id.ToString();
            string sql3 = "INSERT INTO tourist_info(t_id, pass_info, city, country, phone_num, index) VALUES(@t_id, @pass_info, @city, @country, @phone_num, @index)";
            NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, con);

            //Добавим параметр в коллекцию специального типа
            //cmd3.Parameters.Add(new NpgsqlParameter("t_id", NpgsqlDbType.Integer));
            //Добавим значение в параметр в команда
            //cmd3.Parameters[0].Value = id;
            //CAST(@t_id AS integer)
            cmd3.Parameters.AddWithValue("t_id", id);
            cmd3.Parameters.AddWithValue("pass_info", this.tbPass.Text);
            cmd3.Parameters.AddWithValue("city", this.tbCity.Text);
            cmd3.Parameters.AddWithValue("country", this.tbCountry.Text);
            cmd3.Parameters.AddWithValue("phone_num", this.tbPhoneNumber.Text);
            cmd3.Parameters.AddWithValue("index", int.Parse(this.tbIndex.Text));
            cmd3.Prepare();

            cmd3.ExecuteNonQuery();

            this.tbLastname.Text = "";
            this.tbName.Text = "";
            this.tbSurname.Text = "";
            this.tbPass.Text = "";
            this.tbCity.Text = "";
            this.tbCountry.Text = "";
            this.tbPhoneNumber.Text = "";
            this.tbIndex.Text = "";
            //this.label9.Text = id.ToString();

            loadTourist();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
