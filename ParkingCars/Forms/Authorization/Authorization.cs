using ParkingCars.Forms.MeinEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingCars.Forms.MainMenu;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;

namespace ParkingCars.Forms.Authorization
{
    public partial class Authorization : Form
    {
        MD5 md5 = new MD5();

        Thread th;
        public Authorization()
        {
            InitializeComponent();
        }
        ConnectionDB connectionDB = new ConnectionDB();
        public void openMainMenu(object obj)
        {
            Application.Run(new Forms.MainMenu.FormMainMenu());
        }
        public void openMeinEmployee(object obj)
        {
            Application.Run(new Forms.MeinEmployee.MainMenuEmployee());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passwordUser = md5.GetHash(textBox2.Text);

            
            connectionDB.OpenConnection();
            var commandAdmin = new SqlCommand("SELECT login_user FROM register where login_user ='admin'", connectionDB.GetConnection());
            var Admin = commandAdmin.ExecuteScalar();
            string valid_loginAdmin = Convert.ToString(Admin);

            var commandAdmin2 = new SqlCommand("SELECT password_user FROM register where login_user ='admin'", connectionDB.GetConnection());
            var Admin2 = commandAdmin2.ExecuteScalar();
            string valid_passwordAdmin = Convert.ToString(Admin2);



            var commandUser = new SqlCommand("SELECT login_user FROM register where login_user ='user'", connectionDB.GetConnection());
            var User = commandUser.ExecuteScalar();
            string valid_loginUser = Convert.ToString(User);

            var commandUser2 = new SqlCommand("SELECT password_user FROM register where login_user ='user'", connectionDB.GetConnection());
            var User2 = commandUser2.ExecuteScalar();
            string valid_passwordUser = Convert.ToString(User2);

            

            if (loginUser == valid_loginAdmin && passwordUser == valid_passwordAdmin)
            {
                MessageBox.Show("Вы успешно вошли");
                this.Close();
              
                th = new Thread(openMainMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (loginUser == valid_loginUser && passwordUser == valid_passwordUser)
            {
                MessageBox.Show("Вы успешно вошли");

                this.Close();

                th = new Thread(openMeinEmployee);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("Неправльный логин или пароль");
          
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Authorization.Registration.Reg reg = new Registration.Reg();
            reg.ShowDialog();
        }
    }
}
