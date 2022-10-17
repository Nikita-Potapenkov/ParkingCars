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
    enum RowState
    {
        Exited,
        New,
        Modifided,
        ModifidedNew,
        Deleted
    }
    public partial class FormListRentors : Form
    {
        
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
            dataGridView_List__rentors.Columns.Add("rentor_name", "Имя");
            dataGridView_List__rentors.Columns.Add("rentor_middlename", "Отчество");
            dataGridView_List__rentors.Columns.Add("rentor_surname", "Фамилия");
            dataGridView_List__rentors.Columns.Add("rentor_number", "Номер телефона");
            dataGridView_List__rentors.Columns.Add("cars_id", "id автомобиля");
            dataGridView_List__rentors.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                        record.GetString(3), record.GetString(4), record.GetInt32(5), RowState.ModifidedNew);
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
    }
}
