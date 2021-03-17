using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RoboDataBase.BancodeDados.MySqlDb
{
    class ConexaoDB
    {
        private static readonly ConexaoDB instanciaMySql = new ConexaoDB();

        public static ConexaoDB getInstancia()
        {
            return instanciaMySql;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
