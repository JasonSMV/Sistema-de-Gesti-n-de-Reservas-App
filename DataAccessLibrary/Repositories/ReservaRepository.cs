using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Repositories
{
    public class ReservaRepository
    {

        private readonly string connectionString;

        public ReservaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public IEnumerable<ReservaModel> TraerTodas()
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ReservaModel>("ConsultarReservas", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void Agregar(ReservaModel reserva)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SalaID", reserva.SalaID);
                parameters.Add("@FechaReserva", reserva.FechaReserva);
                parameters.Add("@Usuario", reserva.Usuario);

                db.Execute("InsertarReserva", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Actualizar(ReservaModel reserva)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", reserva.ID);
                parameters.Add("@SalaID", reserva.SalaID);
                parameters.Add("@FechaReserva", reserva.FechaReserva);
                parameters.Add("@Usuario", reserva.Usuario);

                db.Execute("ActualizarReserva", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Borrar(int id)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("EliminarReserva", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public bool EstaDisponible(int salaID, DateTime fechaReserva)
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                var result = db.QuerySingle<int>(
                    "ValidarDisponibilidad",
                    new { SalaID = salaID, FechaReserva = fechaReserva },
                    commandType: CommandType.StoredProcedure
                );
                return result == 1; // 1 significa disponible
            }
        }
    }
}
