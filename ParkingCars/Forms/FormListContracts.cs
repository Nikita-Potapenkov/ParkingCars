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
using Excel = Microsoft.Office.Interop.Excel;

namespace ParkingCars.Forms
{
    public partial class FormListContracts : Form
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

        public FormListContracts()
        {
            InitializeComponent();
        }

        public void CreateColumns()
        {
            dataGridView_list_contracts.Columns.Add("contract_id", "id");
            dataGridView_list_contracts.Columns.Add("contract_number", "Номер договора");
            dataGridView_list_contracts.Columns.Add("contract_date_of_conslusion", "Дата подписания");
            dataGridView_list_contracts.Columns.Add("contract_begining_of_the_mouth", "Дата начала месяца");
            dataGridView_list_contracts.Columns.Add("contract_date_extension", "Дата Конца ");
            dataGridView_list_contracts.Columns.Add("contract_valid", "Валидность");
            dataGridView_list_contracts.Columns.Add("contract_parking_id", "Id места");
            dataGridView_list_contracts.Columns.Add("contract_rate_id", "Id тарифа");
            dataGridView_list_contracts.Columns.Add("contract_valid", "Валидность");
            dataGridView_list_contracts.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2),
                      record.GetDateTime(3), record.GetDateTime(4),record.GetBoolean(5), record.GetInt32(6), record.GetInt32(7), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from contracts";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void button_on_all_contracts_Click(object sender, EventArgs e)
        {
          //  dataGridsViews.Query_on_DataGrid_All_Contracts();
          //  dataGridsViews.table.Clear();
           // dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
           // dataGridView_list_contracts.DataSource = dataGridsViews.table;
        }

        private void button_add_contracts_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            var new_number_contract = Convert.ToInt32(textBoxNumCont.Text);
            var new_data = dateTimePicker1.Value;
            var new_data2 = dateTimePicker2.Value;
            var new_data3 = dateTimePicker3.Value;
            var new_place = Convert.ToInt32(textBoxPlace.Text);
            var new_rate = Convert.ToInt32(textBoxRate.Text);
            var QueryAddColor = $"INSERT INTO contracts(contract_number,contract_date_of_conclusion,contract_begining_of_the_mouth," +
                                $"contract_date_extension,contract_parking_id,contract_rate_id)" +
                                $"VALUES ({new_number_contract},'{new_data}','{new_data2}','{new_data3}',{new_place},{new_rate})";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Успех");
        }

        private void FormListContracts_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_list_contracts);
        }

        private void dataGridView_list_contracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_list_contracts.Rows[selectedRow];
           
               
                textBoxIdCont.Text=row.Cells[0].Value.ToString();
                textBoxNumCont.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                dateTimePicker2.Text=row.Cells[3].Value.ToString();
                dateTimePicker3.Text = row.Cells[4].Value.ToString();
                textBoxValid.Text = row.Cells[5].Value.ToString();
                textBoxPlace.Text = row.Cells[6].Value.ToString();
                textBoxRate.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView_list_contracts.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView_list_contracts.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView_list_contracts[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}

