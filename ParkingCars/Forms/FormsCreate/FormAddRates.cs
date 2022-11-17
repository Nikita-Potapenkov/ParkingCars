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

namespace ParkingCars.Forms.FormsCreate
{
    public partial class FormAddRates : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();
        public FormAddRates()
        {
            InitializeComponent();
        }
     
        private void FormAddRates_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();

            var new_name_rate = textBox1.Text;
            var new_rate_price = textBox2.Text;

            var QueryAddColor = $"INSERT INTO rates(rate_name,rate_price)VALUES('{new_name_rate}',{new_rate_price})";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Тариф добавлен");
        }
    }
}
