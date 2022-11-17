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
    public partial class FormAddColors : Form
    {
        public FormAddColors()
        {
            InitializeComponent();
        }
        ConnectionDB connectionDB = new ConnectionDB();
        private void button1_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            var new_color = textBox1.Text;
            var QueryAddColor = $"INSERT INTO colors(color_name)VALUES('{new_color}')";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Цвет добавлен");
        }
    }
}
