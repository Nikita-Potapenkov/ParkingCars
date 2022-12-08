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

        int selectedRow;

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

            var commandQuery_on_Debtors = new SqlCommand("SELECT COUNT(contract_id)FROM contracts WHERE contract_date_extension <= GETDATE() AND contract_valid=1", connectionDB.GetConnection());
            var Query_on_Debtors = commandQuery_on_Debtors.ExecuteScalar();
            label3.Text=Convert.ToString(Query_on_Debtors);

            var commandQuery_onSUM = new SqlCommand("SELECT SUM(rate_price) FROM rates r JOIN contracts cont ON r.rate_id=cont.contract_rate_id AND cont.contract_valid = 1 ", connectionDB.GetConnection());
            var Query_onSUM = commandQuery_onSUM.ExecuteScalar();
            label15.Text = Convert.ToString(Query_onSUM);
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_Debtors();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            dataGridView1.DataSource = dataGridsViews.table;
        }
        private void Change()
        {
            var selectedRowIndex =dataGridView1.CurrentCell.RowIndex;

            var parking_place = textBox1.Text;
            var num_car = textBox2.Text;
            var surname = textBox3.Text;
            var name = textBox4.Text;
            var midname = textBox5.Text;
            var ren_num = textBox6.Text;
            var date = dateTimePicker1.Value;
            var date_ex = dateTimePicker2.Value;
            var valid = textBox8.Text;
         

           if (dataGridView1.Rows[selectedRowIndex].Cells[0].ToString() != string.Empty)
           {
                dataGridView1.Rows[selectedRowIndex].SetValues( parking_place, num_car, surname, name, midname, ren_num,date, date_ex, valid);
                dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modifided;
           }
            /// var updateQuery = $"UPDATE rentors SET rentor_surname='{surname}',rentor_name='{name}',rentor_middlename='{middlename}'" +
            //         $",rentor_number='{number}',rentor_valid='{valid}',rentor_car_id='{car_id}',rentor_contract_id='{contract_id}' WHERE rentor_id ={id}";

            //   var command = new SqlCommand(updateQuery, connectionDB.GetConnection());
            //command.ExecuteNonQuery();

            var DeleteParking = $"UPDATE parking SET parking_valid=1 WHERE parking_id={parking_place}";
            var DeleteContracts = $"UPDATE contracts SET contract_valid = 0 WHERE contract_parking_id={parking_place}";
            var DeleteRentors = $"UPDATE rentors SET rentor_valid=0 WHERE rentor_number='{ren_num}' ";
            var DeleteCars = $"UPDATE cars SET car_valid = 0 WHERE car_number='{num_car}'";


            var command1 = new SqlCommand(DeleteParking, connectionDB.GetConnection());
            command1.ExecuteNonQuery();

            var command2 = new SqlCommand(DeleteContracts, connectionDB.GetConnection());
            command2.ExecuteNonQuery();

            var command3 = new SqlCommand(DeleteRentors, connectionDB.GetConnection());
            command3.ExecuteNonQuery();


            var command4 = new SqlCommand(DeleteCars, connectionDB.GetConnection());
            command4.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно завершено");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();
                dateTimePicker2.Text = row.Cells[7].Value.ToString();
                textBox8.Text = row.Cells[8].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var new_number_contract=textBox1.Text;
            var new_date1 = dateTimePicker2.Value;
            var new_date2 = dateTimePicker2.Value.AddMonths(1);
            var Query = $"UPDATE contracts SET contract_date_extension='{new_date2}',contract_begining_of_the_mouth='{new_date1}' WHERE contract_parking_id={new_number_contract}";
          
            var command = new SqlCommand(Query, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show($"Стоянка продлена до {new_date2}");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var new_number_contract = textBox1.Text;
            var new_date1 = dateTimePicker2.Value;
            var new_date2 = dateTimePicker2.Value.AddDays(1);
            var Query = $"UPDATE contracts SET contract_date_extension='{new_date2}',contract_begining_of_the_mouth='{new_date1}' WHERE contract_parking_id={new_number_contract}";

            var command = new SqlCommand(Query, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show($"Стоянка продлена до {new_date2}");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
    }

