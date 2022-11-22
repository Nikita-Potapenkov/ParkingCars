using ParkingCars.Forms.FormsCreate;
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

namespace ParkingCars.Forms.MeinEmployee
{
    public partial class MainMenuEmployee : Form
    {
        enum RowState
        {
            Exited,
            New,
            Modifided,
            ModifidedNew,
            Deleted
        }
        ConnectionDB connectionDB = new ConnectionDB();
        DataGridsViews dataGridsViews = new DataGridsViews();
        public MainMenuEmployee()
        {
            InitializeComponent();
        }
        
        
       
        private void buttonNewRentors_Click(object sender, EventArgs e)
        {
            Forms.FormsCreate.FormNewRentors formNewRentors = new FormNewRentors();
            formNewRentors.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainMenuEmployee_Load(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            var commandNUM = new SqlCommand("SELECT COUNT(parking_valid)FROM parking WHERE parking_valid=1", connectionDB.GetConnection());
            var NUM = commandNUM.ExecuteScalar();
            label1.Text = Convert.ToString(NUM);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_Main_Menu();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            dataGridView1.DataSource = dataGridsViews.table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
