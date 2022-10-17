using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCars.Forms
{
    public partial class FormListCars : Form
    {

        DataGridsViews dataGridsViews = new DataGridsViews();

        public FormListCars()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormListCars_Load(object sender, EventArgs e)
        {

        }
        public void DataGridViewCarsInsertColumns()
        {
            dataGridView_list_cars.DataSource = dataGridsViews.table;
            dataGridView_list_cars.Columns[0].HeaderText = "id";
            dataGridView_list_cars.Columns[1].HeaderText = "ГОС НОМЕР";
            dataGridView_list_cars.Columns[2].HeaderText = "МАРКА";
            dataGridView_list_cars.Columns[3].HeaderText = "МОДЕЛЬ";
            dataGridView_list_cars.Columns[4].HeaderText = "ЦВЕТ";
        

        }
        private void button_on_all_cars_Click(object sender, EventArgs e)
        {
           

            dataGridsViews.Query_on_DataGridView_All_Cars();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
           DataGridViewCarsInsertColumns();
           


        }

        private void dataGridView_list_cars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
