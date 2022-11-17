using ParkingCars.Forms;
using ParkingCars.Forms.FormsCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //Новое окно со всеми списками 
        private void button_all_lists_Click(object sender, EventArgs e)
        {
            Forms.FormAllLists formAllLists = new FormAllLists();
            formAllLists.ShowDialog();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_reports_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FormsCreate.FormNewRentors formNewRentors = new FormNewRentors();
            formNewRentors.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
