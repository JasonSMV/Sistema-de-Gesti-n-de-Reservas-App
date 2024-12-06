using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLibrary
{
    public class SqlDataAccess
    {

        // Este metodo se encarga de traer datos de las db y mapearlo a una lista de objectos/modelos.
        public List<T> LoadData<T, U>(string sqlStatment, U parameters, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                return (connection.Query<T>(sqlStatment, parameters)).ToList();
            }
        }

        // Este metodo comando para Insert,Update,Delete

        public async Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
