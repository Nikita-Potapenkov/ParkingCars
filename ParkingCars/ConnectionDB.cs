using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCars
{
    internal class ConnectionDB
    {
        //Ввод данных для одключения БД
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4EL3AOO;initial Catalog =Parking;Integrated Security=True");

        //Подсоединение к БД
        public void OpenConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
                Console.WriteLine("CONNECTED");
            }


        }

        //Закрытие БД
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
