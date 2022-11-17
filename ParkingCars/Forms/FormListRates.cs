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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingCars.Forms
{
   
    public partial class FormListRates : Form
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
        public FormListRates()
        {
            InitializeComponent();
        }
        int selectedRow;
        public void CreateColumns()
        {
            dataGridView_list_rates.Columns.Add("rate_id", "id");
            dataGridView_list_rates.Columns.Add("rate_name", "Название");
            dataGridView_list_rates.Columns.Add("rate_price", "Cтоимость");
            dataGridView_list_rates.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from rates";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView_list_rates.CurrentCell.RowIndex;

            var id = textBoxIdPlace.Text;
            var name = textBoxNameRate.Text;
            var price = textBoxPriceRate.Text;
            

            if (dataGridView_list_rates.Rows[selectedRowIndex].Cells[0].ToString() != string.Empty)
            {
                dataGridView_list_rates.Rows[selectedRowIndex].SetValues(id,name,price);
                dataGridView_list_rates.Rows[selectedRowIndex].Cells[3].Value = RowState.Modifided;
            }
            var updateQuery = $"UPDATE rates SET rate_name='{name}',rate_price='{price}'WHERE rate_id='{id}'";

            var command = new SqlCommand(updateQuery, connectionDB.GetConnection());

            command.ExecuteNonQuery();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_on_all_colors_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_DataGrid_All_Rates();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
            dataGridView_list_rates.DataSource = dataGridsViews.table;
        }

        private void button_add_colors_Click(object sender, EventArgs e)
        {
            Forms.FormsCreate.FormAddRates formAddRates = new FormAddRates();
            formAddRates.ShowDialog();

            /*
            connectionDB.OpenConnection();
           
            var new_name_rate = textBoxNameRate.Text;
            var new_rate_price = textBoxPriceRate.Text;

            var QueryAddColor = $"INSERT INTO rates(rate_name,rate_price)VALUES('{new_name_rate}',{new_rate_price})";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Успех");
            */
        }

        private void FormListRates_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_list_rates);
        }

        private void dataGridView_list_rates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_list_rates.Rows[selectedRow];

                textBoxIdPlace.Text= row.Cells[0].Value.ToString();
               textBoxNameRate.Text = row.Cells[1].Value.ToString();
                textBoxPriceRate.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_list_rates);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_list_rates);
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();

            var id = textBoxIdPlace.Text;
            var name = textBoxNameRate.Text;
            var price = textBoxPriceRate.Text;

            var QueryDeleteRates = $"DELETE FROM rates where rate_name='{name}'";
            var command = new SqlCommand(QueryDeleteRates, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            RefreshDataGrid(dataGridView_list_rates);
            MessageBox.Show("Тариф удален");
        }
    }
}
