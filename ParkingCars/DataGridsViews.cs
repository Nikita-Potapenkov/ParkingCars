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
            adapter = new SqlDataAdapter("SELECT contract_parking_id  AS 'Место' ,car_number AS 'Номер авто',rentor_surname AS 'Фамилия',rentor_middlename AS 'Отчество',rentor_name AS 'Имя',rentor_number AS 'Номер тел.'" +
                ",contract_begining_of_the_mouth AS 'Дата оплаты',contract_date_extension AS 'Дата окончания', contract_valid AS 'Дейсвит' FROM rentors r JOIN cars c  ON r.rentor_car_id=c.car_id" +
                " JOIN contracts cont ON r.rentor_contract_id=cont.contract_id  WHERE contract_valid=1", 
                connectionDB.GetConnection());
            table = new DataTable();
        }
        public void Query_on_Debtors()
        {
            adapter = new SqlDataAdapter("SELECT contract_parking_id  AS 'Место' ,car_number AS 'Номер авто',rentor_surname AS 'Фамилия',rentor_middlename AS 'Отчество',rentor_name AS 'Имя',rentor_number AS 'Номер тел.'" +
                ",contract_begining_of_the_mouth AS 'Дата оплаты',contract_date_extension AS 'Дата окончания', contract_valid AS 'Дейсвит' FROM rentors r JOIN cars c  " +
                "ON r.rentor_car_id=c.car_id JOIN contracts cont ON r.rentor_contract_id=cont.contract_id WHERE contract_date_extension <= GETDATE() AND contract_valid=1",
                connectionDB.GetConnection());
            table = new DataTable();
        }
        
       
    }
}
