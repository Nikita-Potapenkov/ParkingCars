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
        public void Query_on_Main_Menu()
        {
            adapter = new SqlDataAdapter("SELECT contract_parking_id ,car_number ,rentor_surname,rentor_middlename,rentor_name,rentor_number" +
                ",contract_begining_of_the_mouth,contract_date_extension, contract_valid FROM rentors r JOIN cars c  ON r.rentor_car_id=c.car_id" +
                " JOIN contracts cont ON r.rentor_contract_id=cont.contract_id", 
                connectionDB.GetConnection());
            table = new DataTable();
        }
        public void Query_on_Debtors()
        {
            adapter = new SqlDataAdapter("SELECT contract_parking_id ,car_number ,rentor_surname,rentor_middlename,rentor_name,rentor_number" +
                ",contract_begining_of_the_mouth,contract_date_extension, contract_valid FROM rentors r JOIN cars c  " +
                "ON r.rentor_car_id=c.car_id JOIN contracts cont ON r.rentor_contract_id=cont.contract_id WHERE contract_date_extension <= GETDATE()",
                connectionDB.GetConnection());
            table = new DataTable();
        }
        
       
    }
}
