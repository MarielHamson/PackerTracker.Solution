using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ThingsController : Controller
  {
    [HttpGet("/things")]
    public ActionResult Index()
    {
      List<Thing> allThings = Thing.GetAll();
      return View(allThings);
    }

    [HttpGet("things/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/things")]
    public ActionResult Show(string name, int price, bool purchased, int weight)
    {
      Thing myThing = new Thing(name, price, purchased, weight);
      return RedirectToAction("Index");
    }
    [HttpGet("/things/{id}")]
    public ActionResult Show(int id)
    {
      Thing foundThing = Thing.Find(id);
      return View(foundThing);
    }

  }
}