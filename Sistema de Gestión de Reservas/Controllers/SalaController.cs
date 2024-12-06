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
    public class SalaController : Controller
    {
        private readonly ISalaRepository _salaRepository;

        public SalaController()
        {
            _salaRepository = new SalaRepository();
        }

        public ActionResult Index()
        {
            var salas = _salaRepository.TraerTodas();
            return View(salas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SalaModel sala)
        {
            if(ModelState.IsValid)
            {
                _salaRepository.Agregar(sala);
                return RedirectToAction("Index");
            }
            return View(sala);
        }

        public ActionResult Edit(int id)
        {
            var sala = _salaRepository.TraerPorId(id);
            if(sala == null)
            {
                return HttpNotFound();
            }
            return View(sala);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SalaModel sala)
        {
            if(ModelState.IsValid)
            {
                _salaRepository.Actualizar(sala);
                return RedirectToAction("Index");
            }
            return View(sala);
        }

        public ActionResult Delete(int id)
        {
            var sala = _salaRepository.TraerPorId(id);
            if(sala == null)
            {
                return HttpNotFound();
            }
            return View(sala);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _salaRepository.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}