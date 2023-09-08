using CoreMVC.Models;
using CoreMVC.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class FlightController : Controller
    {
        private readonly IRepository<Flight> _repository;
        public FlightController(IRepository<Flight> repository)
        {       
            _repository = repository;
        }
        // GET: FlightController
        public IActionResult Index()
        {
            List<Flight> flights = _repository.GetAll();
            return View(flights);
        }

        // GET: FlightController/Details/5
        public IActionResult Details(int id)
        {
           Flight flight = _repository.GetById(id);
            return View(flight);
        }

        // GET: FlightController/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Flight flight)
        {
            try
            {
                _repository.Add(flight);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public IActionResult Edit(int id)
        {
            Flight flight = _repository.GetById(id);
            return View(flight);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Flight flight)
        {
            try
            {
                _repository.Update(flight);
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public IActionResult Delete(int id)
        {
            Flight flight =_repository.GetById(id);
            return View(flight);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id,Flight flight )
        {
            try
            {
                _repository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
