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
   
    public partial class FormListRentors : Form
    {

        enum RowState
        {
            Exited,
            New,
            Modifided,
            ModifidedNew,
            Deleted
        }
        ConnectionDB connectionDB= new ConnectionDB();

        int selectedRow;
        public FormListRentors()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void FormListRentors_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_List__rentors);
        }
        public void CreateColumns()
        {
            dataGridView_List__rentors.Columns.Add("rentor_id", "id");
            dataGridView_List__rentors.Columns.Add("rentor_surname", "Фамилия");
            dataGridView_List__rentors.Columns.Add("rentor_name", "Имя");
            dataGridView_List__rentors.Columns.Add("rentor_middlename", "Отчество");
            dataGridView_List__rentors.Columns.Add("rentor_number", "Номер телефона");
            dataGridView_List__rentors.Columns.Add("rentor_valid", "Дейсвительно");
            dataGridView_List__rentors.Columns.Add("rentor_car_id", "id автомобиля");
            dataGridView_List__rentors.Columns.Add("rentor_contract_id", "id контракта");
            dataGridView_List__rentors.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                        record.GetString(3), record.GetString(4), record.GetBoolean(5),record.GetInt32(6), record.GetInt32(7), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from rentors";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void dataGridView_List__rentors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Update()
        {
            connectionDB.OpenConnection();

            for(int index = 0; index < dataGridView_List__rentors.Rows.Count; index++)
            {

                if ((RowState)dataGridView_List__rentors.Rows[index].Cells[8].Value == RowState.Exited)
                {
                    continue;
                }
                if((RowState)dataGridView_List__rentors.Rows[index].Cells[8].Value == RowState.Modifided)
                {
                    var id = dataGridView_List__rentors.Rows[index].Cells[0].Value.ToString();
                    var surname = dataGridView_List__rentors.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView_List__rentors.Rows[index].Cells[2].Value.ToString();
                    var middlename = dataGridView_List__rentors.Rows[index].Cells[3].Value.ToString();
                    var number = dataGridView_List__rentors.Rows[index].Cells[4].Value.ToString();
                    var valid = dataGridView_List__rentors.Rows[index].Cells[5].Value.ToString();
                    var car_id = dataGridView_List__rentors.Rows[index].Cells[6].Value.ToString();
                    var contract_id = dataGridView_List__rentors.Rows[index].Cells[7].Value.ToString();

                    var updateQuery = $"UPDATE rentors SET rentor_surname='{surname}',rentor_name='{name}',rentor_middlename='{middlename}'" +
                        $",rentor_number='{number}',rentor_valid='{valid}',rentor_car_id='{car_id}',rentor_contract_id='{contract_id}' WHERE rentor_id ={id}";

                    var command = new SqlCommand(updateQuery, connectionDB.GetConnection());

                    command.ExecuteNonQuery();

                }
            }
        }
        private  void Change()
        {
            var selectedRowIndex = dataGridView_List__rentors.CurrentCell.RowIndex;

          var id=  textBoxRentor_id.Text;
            var surname = textBoxRentorSurname.Text;
            var name = textBoxRentorName.Text;
            var middlename = textBoxRentorMiddleName.Text;
          var number =  textBoxRentorNumber.Text;
          var valid=  textBoxValid.Text;
            var car_id = textBoxRentorCar_id.Text;
            var contract_id = textBoxRentorContractId.Text ;

            if (dataGridView_List__rentors.Rows[selectedRowIndex].Cells[0].ToString() != string.Empty)
            {
                dataGridView_List__rentors.Rows[selectedRowIndex].SetValues(id,surname,middlename,name,number,valid,car_id,contract_id);
                dataGridView_List__rentors.Rows[selectedRowIndex].Cells[8].Value = RowState.Modifided;
            }
            var updateQuery = $"UPDATE rentors SET rentor_surname='{surname}',rentor_name='{name}',rentor_middlename='{middlename}'" +
                      $",rentor_number='{number}',rentor_valid='{valid}',rentor_car_id='{car_id}',rentor_contract_id='{contract_id}' WHERE rentor_id ={id}";

            var command = new SqlCommand(updateQuery, connectionDB.GetConnection());

            command.ExecuteNonQuery();
        }
        private void dataGridView_List__rentors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_List__rentors.Rows[selectedRow];

                textBoxRentor_id.Text = row.Cells[0].Value.ToString();
                textBoxRentorSurname.Text = row.Cells[1].Value.ToString();
                textBoxRentorName.Text = row.Cells[2].Value.ToString();
                textBoxRentorMiddleName.Text = row.Cells[3].Value.ToString();
                textBoxRentorNumber.Text = row.Cells[4].Value.ToString();
                textBoxValid.Text = row.Cells[5].Value.ToString();
                textBoxRentorCar_id.Text = row.Cells[6].Value.ToString();
                textBoxRentorContractId.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Change();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Update();
           //CreateColumns();
           // RefreshDataGrid(dataGridView_List__rentors);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView_List__rentors.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView_List__rentors.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView_List__rentors[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
