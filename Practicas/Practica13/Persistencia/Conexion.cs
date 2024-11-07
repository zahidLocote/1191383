using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Persistencia
{
    public class Conexion
    {
        private MySqlConnection mySqlConnection = new 
            MySqlConnection("server=localhost;Port=3306;database=p13;uid=root;pwd=diego123;");

        public MySqlConnection AbrirConexion()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
                mySqlConnection.Open();
            return mySqlConnection;
        }

        public MySqlConnection CerrarConexion()
        {
            if(mySqlConnection.State == System.Data.ConnectionState.Open)
                mySqlConnection.Clone();
            return mySqlConnection;
        }
    }
}
