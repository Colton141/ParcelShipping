using Microsoft.AspNetCore.Mvc;
using ParcelShipping.Models;
using System.Collections.Generic;


namespace ParcelShipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(string height, string width, string length, string weight)
    {
      Parcel myParcel = new Parcel(height, width, length, weight);
      return RedirectToAction("Index");
    }

  }
}
