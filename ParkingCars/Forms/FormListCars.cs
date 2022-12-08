using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ParkingCars.Forms
{
    public partial class FormListCars : Form
    {
        enum RowState
        {
            Exited,
            New,
            Modifided,
            ModifidedNew,
            Deleted
        }
        DataGridsViews dataGridsViews = new DataGridsViews();
        ConnectionDB connectionDB = new ConnectionDB();

        int selectedRow;
        public FormListCars()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormListCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.parkingDataSet.colors);
            CreateColumns();
            RefreshDataGrid(dataGridView_list_cars);
        }

        public void CreateColumns()
        {
            dataGridView_list_cars.Columns.Add("car_id", "id");
            dataGridView_list_cars.Columns.Add("car_number", "Номер");
            dataGridView_list_cars.Columns.Add("car_mark", "Марка");
            dataGridView_list_cars.Columns.Add("car_model", "Модель");
            dataGridView_list_cars.Columns.Add("car_valid","Дейсвтительность");
            dataGridView_list_cars.Columns.Add("car_color_id", "id цвета");
            
            dataGridView_list_cars.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                        record.GetString(3),  record.GetBoolean(4),record.GetInt32(5), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from cars";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
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
           

        //    dataGridsViews.Query_on_DataGridView_All_Cars();
         //   dataGridsViews.table.Clear();
         //   dataGridsViews.adapter.Fill(dataGridsViews.table);
         //  DataGridViewCarsInsertColumns();
           


        }

        private void dataGridView_list_cars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
    
        private void button_add_car_Click(object sender, EventArgs e)
        {
           connectionDB.OpenConnection();
           

            var new_num_car = textBoxNumberCar.Text;
            var new_mark= textBoxMarkCar.Text;
            var new_model = textBoxModelCar.Text;
            var new_color_car = Convert.ToInt32(comboBoxColorCar.SelectedValue);


            var QueryAddColor = $"INSERT INTO cars(car_number,car_mark,car_model,car_color_id)" +
                $"VALUES('{new_num_car}','{new_mark}','{new_model}',{new_color_car})";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Данные об Автомобиле успешно добавлены");
        }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxColorCar.SelectedValue.ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_list_cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_list_cars.Rows[selectedRow];

                textBoxIdCar.Text = row.Cells[0].Value.ToString();
                textBoxNumberCar.Text = row.Cells[1].Value.ToString();
                textBoxMarkCar.Text = row.Cells[2].Value.ToString();
                textBoxModelCar.Text = row.Cells[3].Value.ToString();
                textBoxValid.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView_list_cars.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView_list_cars.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView_list_cars[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
