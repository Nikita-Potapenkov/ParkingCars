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
    public partial class FormListPlaces : Form
    {
        enum RowState
        {
            Exited,
            New,
            Modifided,
            ModifidedNew,
            Deleted
        }

        DataGridsViews dataGridsViews = new DataGridsViews();
        ConnectionDB connectionDB = new ConnectionDB();

        int selectedRow;
        public FormListPlaces()
        {
            InitializeComponent();
        }

        public void CreateColumns()
        {
            dataGridView_list_place.Columns.Add("parking_id", "id");
            dataGridView_list_place.Columns.Add("parking_place", "Место");
            dataGridView_list_place.Columns.Add("parking_valid", "Действительность");
            dataGridView_list_place.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1),record.GetBoolean(2), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from parking";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void button_on_all_places_Click(object sender, EventArgs e)
        {
            dataGridsViews.Query_on_DataGrid_All_Places();
            dataGridsViews.table.Clear();
            dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
            dataGridView_list_place.DataSource = dataGridsViews.table;
        }

        private void button_add_place_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();
            
            var new_place = Convert.ToInt32(textBoxParkingPlace.Text);
            var new_tf = Convert.ToBoolean(textBox1.Text);
            var QueryAddColor = $"INSERT INTO parking(parking_place,parking_valid)VALUES('{new_place}','{new_tf}')";
            var command = new SqlCommand(QueryAddColor, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Успех");
        }

        private void dataGridView_list_place_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_list_place.Rows[selectedRow];

                textBoxIdPlace.Text = row.Cells[0].Value.ToString();
               textBoxParkingPlace.Text = row.Cells[1].Value.ToString();
               textBox1.Text=row.Cells[2].Value.ToString();
            }
        }

        private void FormListPlaces_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_list_place);
        }

        private void dataGridView_list_place_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
