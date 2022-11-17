using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingCars.Forms;

namespace ParkingCars
{
    internal class DataGridsViews
    {
      
        ConnectionDB connectionDB = new ConnectionDB();

        
        public SqlDataAdapter adapter = null;
        public DataTable table = null;

        public void Query_on_DataGridView_All_Cars()
        {
            adapter = new SqlDataAdapter("SELECT cars.car_id,cars.car_number,cars.car_mark,cars.car_model,colors.color_name " +
                "FROM cars inner join colors on cars.car_color_id=colors.color_id", connectionDB.GetConnection());
            table = new DataTable();
        }


        public void Query_on_DataGrid_Cars_and_Rentors()
        {
            adapter = new SqlDataAdapter("SELECT rentors.rentor_surname,cars.cars_number,cars.cars_mark,cars.cars_model " +
                "FROM rentors inner join cars on rentors.cars_id=cars.cars_id", 
                connectionDB.GetConnection());
            table = new DataTable();
        }

        public void Query_on_DataGridView_All_Colors()
        {
            adapter = new SqlDataAdapter("SELECT * FROM colors", connectionDB.GetConnection());
            table = new DataTable();
        }
        
        public void Query_on_DataGrid_All_Contracts()
        {
            adapter = new SqlDataAdapter("SELECT * FROM contracts", connectionDB.GetConnection());
            table = new DataTable();

       
        }

        public void Query_on_DataGrid_All_Places()
        {
            adapter = new SqlDataAdapter("SELECT * FROM parking", connectionDB.GetConnection());
            table = new DataTable();


        }

        public void Query_on_DataGrid_All_Rates()
        {
            adapter = new SqlDataAdapter("SELECT * FROM rates", connectionDB.GetConnection());
            table = new DataTable();

        }

       
    }
}
