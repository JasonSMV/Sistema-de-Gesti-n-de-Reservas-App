using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IReservaRepository
    {
        List<ReservaViewModel> TraerTodas();
        ReservaViewModel TraerPorId(int id);
        List<ReservaViewModel> FiltrarReservas(int? salaId, DateTime? fechaDesde, DateTime? fechaHasta);
        Task Agregar(ReservaModel sala);
        Task Actualizar(ReservaModel sala);
        Task Borrar(int id);
    }
}
