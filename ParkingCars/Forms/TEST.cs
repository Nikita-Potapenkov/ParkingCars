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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }
        ConnectionDB connectionDB = new ConnectionDB();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4EL3AOO;initial Catalog =PARKING;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxParking()
        {


            string sql = "SELECT * FROM parking WHERE parking_valid = 'false'";


            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
               // comboBox1.DisplayMember = "parking_place";
              //  comboBox1.ValueMember = "parking_id";
               // comboBox1.DataSource = table;
            }


        }
        private void TEST_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet2.rates". При необходимости она может быть перемещена или удалена.
            this.ratesTableAdapter.Fill(this.parkingDataSet2.rates);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.parkingDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.parkingDataSet.colors);
            LoadComboBoxParking();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            var new_surname = textBoxSurname.Text;
            var new_middlename = textBoxMiddleName.Text;
            var new_name = textBoxName.Text;
            var new_number_phone = textBoxNumberPhone.Text;

            var new_nuber_car =  textBoxNumberCar.Text;
            var new_mark_car= textBoxMarkCar.Text;
            var new_model_car=textBoxModelCar.Text;
         //   var new_color_car = Convert.ToInt32(textBoxColor.Text);

            var new_number_contract = Convert.ToInt32(textBoxNumberContract.Text) ;
            var new_date1 = dateTimePicker.Value;
            var new_date2 = dateTimePicker2.Value;
            var new_date3 = dateTimePicker3.Value.AddMonths(1);
         //   var new_place = Convert.ToInt32(textBoxParkingPlace.Text);
          //  var new_rate = Convert.ToInt32(textBoxRate.Text);

            var Query = $"INSERT INTO contracts(contract_number,contract_date_of_conclusion" +
                $",contract_begining_of_the_mouth,contract_date_extension,contract_parking_id,contract_rate_id) " +
                $"VALUES ({new_number_contract},'{new_date1}','{new_date2}','{new_date3}')";
            var Query2 = $"INSERT INTO cars (car_number,car_mark,car_model,car_color_id)" +
                $" VALUES ('{new_nuber_car}','{new_mark_car}','{new_model_car}')";
            var Query3 = $"INSERT INTO rentors(rentor_surname,rentor_middlename,rentor_name,rentor_number,rentor_car_id,rentor_contract_id)" +
                $"Values('{new_surname}','{new_middlename}','{new_name}','{new_number_phone}'{new_nuber_car},{new_number_contract})";
            var command = new SqlCommand(Query, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            var command2=new SqlCommand(Query2, connectionDB.GetConnection());
            command2.ExecuteNonQuery();
            var command3=new SqlCommand(Query3, connectionDB.GetConnection());
            command3.ExecuteNonQuery();
            MessageBox.Show("Успех");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          var i=  dateTimePicker3.Value.AddMonths(1).ToString();
            MessageBox.Show(i);
        }
    }
}
