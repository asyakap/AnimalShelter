using Microsoft.AspNetCore.Mvc;
using Shelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly ShelterContext _db;

    public AnimalsController(ShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.OrderBy(animal => animal.Name).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }
  }
}