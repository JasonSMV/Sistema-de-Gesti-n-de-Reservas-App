using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using DataAccessLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_de_Gestión_de_Reservas.Controllers
{
    public class ReservasController : Controller
    {
        // 
        private readonly IReservaRepository _reservaRepository;
        private readonly ISalaRepository _salaRepository;


        public ReservasController()
        {
            _reservaRepository = new ReservaRepository();
            _salaRepository = new SalaRepository();
        }

        public ActionResult Index()
        {
            var reserva = _reservaRepository.TraerTodas();
            ViewBag.Salas = _salaRepository.TraerTodas();

            return View(reserva);
        }

        public ActionResult Create()
        {
            ViewBag.Salas = _salaRepository.TraerTodas();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaModel reserva)
        {
            if(ModelState.IsValid)
            {
                _reservaRepository.Agregar(reserva);
                return RedirectToAction("Index");
            }
            return View(reserva);
        }

        [HttpPost]
        public ActionResult FiltrarReservas(int? salaId, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            var reservas = _reservaRepository.FiltrarReservas(salaId, fechaDesde, fechaHasta);
            return PartialView("_ReservasTable", reservas);
        }

        public ActionResult Edit(int id)
        {
            var reserva = _reservaRepository.TraerPorId(id);
            ViewBag.Salas = _salaRepository.TraerTodas();

            if(reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservaModel reserva)
        {
            if(ModelState.IsValid)
            {
                _reservaRepository.Actualizar(reserva);
                return RedirectToAction("Index");
            }
            return View(reserva);
        }

        public ActionResult Delete(int id)
        {
            var reserva = _reservaRepository.TraerPorId(id);
            if(reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _reservaRepository.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}