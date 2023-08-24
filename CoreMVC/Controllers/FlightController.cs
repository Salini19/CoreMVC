using CoreMVC.Models;
using CoreMVC.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class FlightController : Controller
    {
        private readonly IRepository<Flight> repository;
        public FlightController(IRepository<Flight> _repository)
        {
            repository = _repository;
        }
        // GET: FlightController
        public IActionResult Index()
        {
            List<Flight> flights = repository.GetAll();
            return View(flights);
        }

        // GET: FlightController/Details/5
        public IActionResult Details(int id)
        {
           Flight f= repository.GetById(id);
            return View(f);
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
                repository.Add(flight);
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
            Flight f = repository.GetById(id);
            return View(f);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Flight flight)
        {
            try
            {
                repository.Update(flight);
              
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
            Flight f = repository.GetById(id);
            return View(f);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id,Flight flight )
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
