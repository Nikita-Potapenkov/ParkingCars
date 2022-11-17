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
    public partial class FormAllLists : Form
    {
        ConnectionDB connectionDB= new ConnectionDB();
        public FormAllLists()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void button_list_rentors_Click(object sender, EventArgs e)
        {
     
            Forms.FormListRentors formListRentors = new FormListRentors();
            formListRentors.ShowDialog();

        }

        private void button_list_cars_Click(object sender, EventArgs e)
        {

            Forms.FormListCars formListCars = new FormListCars();
            formListCars.ShowDialog();

        }
        DataGridsViews dataGridsViews = new DataGridsViews();

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridsViews.Query_on_DataGrid_Cars_and_Rentors();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            dataGridView1.DataSource = dataGridsViews.table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_list_colors_Click(object sender, EventArgs e)
        {
            Forms.FormListColors formListColors = new FormListColors();
            formListColors.ShowDialog();
        }

        private void button_list_contract_Click(object sender, EventArgs e)
        {
            Forms.FormListContracts formListContrats = new FormListContracts();
            formListContrats.ShowDialog();
        }

        private void button_list_places_Click(object sender, EventArgs e)
        {
            Forms.FormListPlaces formListplaces = new FormListPlaces();
            formListplaces.ShowDialog();
        }

        private void button_list_rates_Click(object sender, EventArgs e)
        {
            Forms.FormListRates formListRates = new FormListRates();
            formListRates.ShowDialog();
        }

        private void FormAllLists_Load(object sender, EventArgs e)
        {

        }
    }
}
