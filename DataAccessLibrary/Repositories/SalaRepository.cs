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
using DataAccessLibrary.Interfaces;

namespace DataAccessLibrary.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        private readonly string connectionString;
        private readonly SqlDataAccess db;

        public SalaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            db = new SqlDataAccess();
        }

        public List<SalaModel> TraerTodas()
        {
            // Se manda el nombre del store procedure. 
            return db.LoadData<SalaModel, dynamic>("ConsultarSalas", new { }, connectionString);
        }

        public async Task Agregar(SalaModel sala)
        {
            var parameters = new
            {
                Nombre = sala.Nombre,
                Capacidad = sala.Capacidad,
                Disponibilidad = sala.Disponibilidad
            };

            await db.SaveData("InsertarSala", parameters, connectionString);
        }

        public async Task Actualizar(SalaModel sala)
        {
            var parameters = new
            {
                ID = sala.ID,
                Nombre = sala.Nombre,
                Capacidad = sala.Capacidad,
                Disponibilidad = sala.Disponibilidad
            };

            await db.SaveData("ActualizarSala", parameters, connectionString);
        }

        public async Task Borrar(int id)
        {
            await db.SaveData("EliminarSala", new { ID = id }, connectionString);
        }
    }
}
