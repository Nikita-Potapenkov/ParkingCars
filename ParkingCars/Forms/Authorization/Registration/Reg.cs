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

namespace ParkingCars.Forms.Authorization.Registration
{
    public partial class Reg : Form
    {
        MD5 md5 = new MD5();
        ConnectionDB connectionDB = new ConnectionDB();
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            connectionDB.OpenConnection();
            var login = textBox1.Text;

            var password = md5.GetHash(textBox2.Text);
         
            var Query = $"INSERT INTO register(login_user,password_user,is_admin) VALUES ('{login}','{password}',1)";
            
            var command = new SqlCommand(Query, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Успешно создан");
            Close();
          
           
        }
    }
}
