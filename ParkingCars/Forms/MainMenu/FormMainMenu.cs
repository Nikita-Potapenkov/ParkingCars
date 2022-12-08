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

namespace ParkingCars.Forms.MainMenu
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_all_lists_Click(object sender, EventArgs e)
        {
            Forms.FormAllLists formAllLists = new FormAllLists();
            formAllLists.ShowDialog();
        }

        private void button_reports_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.MeinEmployee.MainMenuEmployee mainMenuEmployee = new MainMenuEmployee();
            mainMenuEmployee.ShowDialog();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
