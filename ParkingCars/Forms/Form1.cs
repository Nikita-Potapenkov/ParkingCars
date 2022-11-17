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
    public partial class Form1 : Form
    {


        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4EL3AOO;initial Catalog =PARKING;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
       
        private void LoadComboBox()
        {
            

            string sql = "SELECT * FROM parking WHERE parking_valid = 'false'";
           

            using(SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBox1.DisplayMember = "parking_place";
                comboBox1.ValueMember = "parking_id";
                comboBox1.DataSource = table;
            }

          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
