using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestionDeReservas.Data.Repositories
{
    public class SalaRepository
    {

        private readonly string connectionString;

        public SalaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public IEnumerable<SalaModel> GetAll()
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Sala>("ConsultarSalas", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void Add(Sala sala)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Nombre", sala.Nombre);
                parameters.Add("@Capacidad", sala.Capacidad);
                parameters.Add("@Disponibilidad", sala.Disponibilidad);

                db.Execute("InsertarSala", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Sala sala)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", sala.ID);
                parameters.Add("@Nombre", sala.Nombre);
                parameters.Add("@Capacidad", sala.Capacidad);
                parameters.Add("@Disponibilidad", sala.Disponibilidad);

                db.Execute("ActualizarSala", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EliminarSala", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }
    }

}
