using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISalaRepository
    {
        List<SalaModel> TraerTodas();
        Task Agregar(SalaModel sala);
        Task Actualizar(SalaModel sala);
        Task Borrar(int id);

    }
}
