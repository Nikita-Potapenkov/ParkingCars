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

namespace ParkingCars.Forms.FormsCreate
{
    public partial class FormNewRentors : Form
    {
        ConnectionDB connectionDB = new ConnectionDB();
        public FormNewRentors()
        {
            InitializeComponent();
        }
        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4EL3AOO;initial Catalog =PARKING;Integrated Security=True");
        private void LoadComboBoxParking()
        {
            //ЗАГРУЗКА ДЛЯ TEXTBOX

            string sql = "SELECT * FROM parking WHERE parking_valid ='true'";
            string sql1= "SELECT * FROM colors";
            string sql2 = "SELECT * FROM rates";
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBox2.DisplayMember = "parking_place";
                comboBox2.ValueMember = "parking_id";
                comboBox2.DataSource = table;
            }

            using (SqlCommand cmd = new SqlCommand(sql1, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBox1.DisplayMember = "color_name";
                comboBox1.ValueMember = "color_id";
                comboBox1.DataSource = table;
            }
            using (SqlCommand cmd = new SqlCommand(sql2, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBox3.DisplayMember = "rate_name";
                comboBox3.ValueMember = "rate_id";
                comboBox3.DataSource = table;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();

            var new_surname = textBoxSurname.Text;
            var new_middlename = textBoxMiddleName.Text;
            var new_name = textBoxName.Text;
            var new_number_phone = textBoxNumberPhone.Text;

            var new_number_car = textBoxNumberCar.Text;
            var new_mark_car = textBoxMarkCar.Text;
            var new_model_car = textBoxModelCar.Text;
            var new_color_car = Convert.ToInt32(comboBox1.SelectedValue);
           
           
            var new_number_contract = Convert.ToInt32(textBoxNumberContract.Text);
            var new_date1 = dateTimePicker.Value;
            var new_date2 = dateTimePicker2.Value;

            var new_place = Convert.ToInt32(comboBox2.SelectedValue);
            var new_rate = Convert.ToInt32(comboBox3.SelectedValue);
            
            if (comboBox3.SelectedIndex==0||comboBox3.SelectedIndex == 1)
            {
                var new_date3 = dateTimePicker.Value.AddMonths(1);
                var Query = $"INSERT INTO contracts(contract_number,contract_date_of_conclusion" +
                $",contract_begining_of_the_mouth,contract_date_extension,contract_parking_id,contract_rate_id) " +
                $"VALUES ({new_number_contract},'{new_date1}','{new_date2}','{new_date3}',{new_place},{new_rate})";
                //     var new_date3 = dateTimePicker.Value.AddMonths(1);
                var command = new SqlCommand(Query, connectionDB.GetConnection());
                command.ExecuteNonQuery();
            }
            else if(comboBox3.SelectedIndex == 2 || comboBox3.SelectedIndex == 3)
            {
                var new_date3 = dateTimePicker.Value.AddDays(1);
                var Query = $"INSERT INTO contracts(contract_number,contract_date_of_conclusion" +
                $",contract_begining_of_the_mouth,contract_date_extension,contract_parking_id,contract_rate_id) " +
                $"VALUES ({new_number_contract},'{new_date1}','{new_date2}','{new_date3}',{new_place},{new_rate})";
                //     var new_date3 = dateTimePicker.Value.AddMonths(1);
                var command = new SqlCommand(Query, connectionDB.GetConnection());
                command.ExecuteNonQuery();
            }
          //  var new_date3= dateTimePicker.Value.AddMonths(1);
            
          //  var new_place = Convert.ToInt32(comboBox2.SelectedValue);
         //   var new_rate = Convert.ToInt32(comboBox3.SelectedValue);



         //   var Query = $"INSERT INTO contracts(contract_number,contract_date_of_conclusion" +
         //       $",contract_begining_of_the_mouth,contract_date_extension,contract_parking_id,contract_rate_id) " +
         //       $"VALUES ({new_number_contract},'{new_date1}','{new_date2}','{new_date3}',{new_place},{new_rate})";

      //      var command = new SqlCommand(Query, connectionDB.GetConnection());
        //    command.ExecuteNonQuery();



            var Query2 = $"INSERT INTO cars(car_number,car_mark,car_model,car_color_id)"+
                $"VALUES('{new_number_car}','{new_mark_car}','{new_model_car}',{new_color_car})";

            var command2 = new SqlCommand(Query2, connectionDB.GetConnection());
            command2.ExecuteNonQuery();



            var commandNUM = new SqlCommand("Select Top 1 car_id From cars Order By  car_id Desc", connectionDB.GetConnection());
            var NUM = commandNUM.ExecuteScalar();

            var commandCUM = new SqlCommand("Select Top 1 contract_id From contracts Order By  contract_id Desc", connectionDB.GetConnection());
            var CUM = commandCUM.ExecuteScalar().ToString();

            MessageBox.Show("Успех");


            var Query3 = $"INSERT INTO rentors(rentor_surname,rentor_middlename,rentor_name,rentor_number,rentor_car_id,rentor_contract_id)" +
                $"Values('{new_surname}','{new_middlename}','{new_name}','{new_number_phone}',{NUM},{CUM})";
            
            var command3 = new SqlCommand(Query3, connectionDB.GetConnection());

            command3.ExecuteNonQuery();
            MessageBox.Show("Успех");

            var Query4 = $"UPDATE parking SET parking_valid=0 WHERE parking_id={new_place}";

            var command4 = new SqlCommand(Query4, connectionDB.GetConnection());
            command4.ExecuteNonQuery();
        }

        private void FormNewRentors_Load(object sender, EventArgs e)
        {
            LoadComboBoxParking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = dateTimePicker.Value.AddMonths(1).ToString();
            MessageBox.Show(a);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
