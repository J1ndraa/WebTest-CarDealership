using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Controllers
{
	public class NabidkyController : Controller
	{
		private readonly DB_Context _context;
		private readonly IWebHostEnvironment _env;

		public NabidkyController(DB_Context context, IWebHostEnvironment env)
		{
			_context = context;
			_env = env;
		}


		public IActionResult Index()
		{
			var vehicles = _context.Vehicles.ToList();
			return View(vehicles);
		}


		public IActionResult Details(int id)
		{
			var vehicle = _context.Vehicles.FirstOrDefault(v => v.Id == id);
			if (vehicle == null) return NotFound();

			return View(vehicle);
		}


		public IActionResult Create()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Vehicle vehicle, IFormFile? imageFile)
		{
            if (ModelState.IsValid)
			{
				if (imageFile != null && imageFile.Length > 0)
				{
					string uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");

					string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
					string filePath = Path.Combine(uploadsFolder, fileName);

					using (var stream = new FileStream(filePath, FileMode.Create)) {imageFile.CopyTo(stream); }

					vehicle.Image = "/uploads/" + fileName;
				}

				_context.Add(vehicle);
				_context.SaveChanges();
                return RedirectToAction(nameof(Index));
			}



			return View(vehicle);
		}


		public IActionResult Edit(int id)
		{
			var vehicle = _context.Vehicles.Find(id);
			if (vehicle == null) return NotFound();
			return View(vehicle);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, Vehicle vehicle, IFormFile? imageFile)
		{
			var existing = _context.Vehicles.Find(id);
			if (existing == null) return NotFound();

			if (ModelState.IsValid)
			{
                //Update properties
                existing.Brand = vehicle.Brand;
				existing.Model = vehicle.Model;
				existing.Year = vehicle.Year;
				existing.Kilometers = vehicle.Kilometers;
				existing.Fuel = vehicle.Fuel;
				existing.Body_type = vehicle.Body_type;
				existing.SPZ = vehicle.SPZ;
				existing.Status = vehicle.Status;
				existing.From = vehicle.From;
				existing.Note = vehicle.Note;

                //if image is uploaded, save it to uploads folder
                if (imageFile != null && imageFile.Length > 0)
				{
					string uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");
					string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
					string filePath = Path.Combine(uploadsFolder, fileName);

					using (var stream = new FileStream(filePath, FileMode.Create)) { imageFile.CopyTo(stream); }

					existing.Image = "/uploads/" + fileName;
				}

				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}

			return View(vehicle);
		}


		//check while creating new or editing vehicle
        [HttpGet]
        public IActionResult CheckSPZ(string spz)
        {
            if (string.IsNullOrWhiteSpace(spz))
                return Json(true);

            bool exists = _context.Vehicles.Any(v => v.SPZ == spz);
            return Json(!exists); //returns false if SPZ exists
        }


        public IActionResult Delete(int id)
		{
			var vehicle = _context.Vehicles.Find(id);
			if (vehicle == null) return NotFound();
			return View(vehicle);
		}


		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var vehicle = _context.Vehicles.Find(id);

            //check if vehicle exists
            if (vehicle != null)
			{
				_context.Vehicles.Remove(vehicle);
				_context.SaveChanges();
			}

			return RedirectToAction(nameof(Index));
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
