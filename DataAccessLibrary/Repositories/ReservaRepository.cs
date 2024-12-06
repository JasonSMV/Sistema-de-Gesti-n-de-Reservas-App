﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Security.Cryptography;

namespace DataAccessLibrary.Repositories
{
    public class ReservaRepository
    {

        private readonly string connectionString;
        private readonly SqlDataAccess db;


        public ReservaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            db = new SqlDataAccess();

        }

        public List<ReservaModel> TraerTodas()
        {
            // Se manda el nombre del store procedure. 
            return db.LoadData<ReservaModel, dynamic>("ConsultarReservas", new { }, connectionString);
        }


        public ReservaModel TraerPorId(int id)
        {

            var parameters = new { ID = id };
            return db.LoadData<ReservaModel, dynamic>("ConsultarReservaPorId", parameters, connectionString).FirstOrDefault();

            ;
        }

        public async Task Agregar(ReservaModel reserva)
        {
            var parameters = new
            {
                Usuario = reserva.Usuario,
                SalaID = reserva.SalaID,
                FechaReserva = reserva.FechaReserva
            };

            await db.SaveData("AgregarReserva", parameters, connectionString);
        }

        public async Task Actualizar(ReservaModel reserva)
        {
            var parameters = new
            {
                ID = reserva.ID,
                Usuario = reserva.Usuario,
                SalaID = reserva.SalaID,
                FechaReserva = reserva.FechaReserva
            };

            await db.SaveData("ActualizarReserva", parameters, connectionString);
        }

        public async Task Borrar(int id)
        {
            await db.SaveData("EliminarReserva", new { ID = id }, connectionString);
        }

        public bool EstaDisponible(int salaID, DateTime fechaReserva)
        {

            var parameters = new { SalaID = salaID, FechaReserva = fechaReserva };

            int resultado = db.LoadData<int, dynamic>("ValidarDisponibilidad", parameters, connectionString).FirstOrDefault();

            return resultado == 1;

        }



    }
}
