using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {

        private string _connectionString { get; }
        private SqlDataAccess db = new SqlDataAccess();

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SalaModel> GetSalas()
        {
            string sql = "ConsultarSalas";
            return db.LoadData<SalaModel, dynamic>(sql, new { }, _connectionString);
        }
    }
}
