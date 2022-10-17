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

namespace ParkingCars.Forms
{
    public partial class FormListColors : Form
    {
        DataGridsViews dataGridsViews = new DataGridsViews();
        ConnectionDB connectionDB= new ConnectionDB();
        public FormListColors()
        {
            InitializeComponent();
        }

        private void button_on_all_colors_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_DataGridView_All_Colors();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
            dataGridView_list_colors.DataSource = dataGridsViews.table;
        }
       
        private void button_add_colors_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            var new_color = textBox_new_color.Text;
            var QueryAddColor = $"INSERT INTO colors(color_name)VALUES('{new_color}')";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Успех");
        }

        private void textBox_new_color_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button_update_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_DataGridView_All_Colors();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
            dataGridView_list_colors.DataSource = dataGridsViews.table;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormListColors_Load(object sender, EventArgs e)
        {

        }
    }
}
