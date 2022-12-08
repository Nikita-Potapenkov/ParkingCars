using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
namespace ParkingCars.Forms
{
    public partial class FormListColors : Form
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
        ConnectionDB connectionDB= new ConnectionDB();

        int selectedRow;

        public FormListColors()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dataGridView_list_colors.Columns.Add("color_id", "id");
            dataGridView_list_colors.Columns.Add("color_name", "ЦВЕТ");
            dataGridView_list_colors.Columns.Add("IsNew", String.Empty);
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifidedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStriing = $"select * from colors";

            SqlCommand command = new SqlCommand(queryStriing, connectionDB.GetConnection());

            connectionDB.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void button_on_all_colors_Click(object sender, EventArgs e)
        {
         //   dataGridsViews.Query_on_DataGridView_All_Colors();
         //   dataGridsViews.table.Clear();
         //   dataGridsViews.adapter.Fill(dataGridsViews.table);
            // DataGridViewCarsInsertColumns();
          //  dataGridView_list_colors.DataSource = dataGridsViews.table;
        }
       
        private void button_add_colors_Click(object sender, EventArgs e)
        {
            Forms.FormsCreate.FormAddColors formAddColors = new FormsCreate.FormAddColors();
             formAddColors.ShowDialog();
           
        }

        private void textBox_new_color_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button_update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_list_colors);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormListColors_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_list_colors);
        }

        private void dataGridView_list_colors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_list_colors.Rows[selectedRow];
                textBoxIDColors.Text = row.Cells[0].Value.ToString();
                textBox_new_color.Text = row.Cells[1].Value.ToString();
               
            }
        }
        /*
        private void Update()
        {
            connectionDB.OpenConnection();
            for(int index=0;index<dataGridView_list_colors.Rows.Count;index++)
            {
                var rowState = (RowState)dataGridView_list_colors.Rows[index].Cells[2].Value;

                if(rowState== RowState.Exited)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_list_colors.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from clolors where id={id}";

                    var command = new SqlCommand(deleteQuery,connectionDB.GetConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modifided)
                {
                    var id = dataGridView_list_colors.Rows[index].Cells[0].Value.ToString();
                    var color = dataGridView_list_colors.Rows[index].Cells[1].Value.ToString();

                    var CQ = $"update colors set color_name='{color}'where color_id='{id}'";

                    var command = new SqlCommand(CQ,connectionDB.GetConnection());
                    command.ExecuteNonQuery ();
                }
            }
        }
        */
        private void Change()
        {
            var selectedRowIndex = dataGridView_list_colors.CurrentCell.RowIndex;

            var id = textBoxIDColors.Text;
            var color = textBox_new_color.Text;


            if (dataGridView_list_colors.Rows[selectedRowIndex].Cells[0].ToString() != string.Empty)
            {
                dataGridView_list_colors.Rows[selectedRowIndex].SetValues(id,color);
                dataGridView_list_colors.Rows[selectedRowIndex].Cells[2].Value = RowState.Modifided;
            }
            var CQ = $"update colors set color_name='{color}'where color_id='{id}'";

            var command = new SqlCommand(CQ, connectionDB.GetConnection());
            command.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Change();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //Update();
        }

        private void textBoxIDColors_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connectionDB.OpenConnection();

            var id = textBoxIDColors.Text;
            var name = textBox_new_color.Text;

            var QueryDeleteRates = $"DELETE FROM colors where color_name='{name}'";
            var command = new SqlCommand(QueryDeleteRates, connectionDB.GetConnection());
            command.ExecuteNonQuery();
            RefreshDataGrid(dataGridView_list_colors);
            MessageBox.Show("Цвет удален");

        }

        private void dataGridView_list_colors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView_list_colors.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView_list_colors.ColumnCount-1; j++)
                {
                    wsh.Cells[i + 1, j+1] = dataGridView_list_colors[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
