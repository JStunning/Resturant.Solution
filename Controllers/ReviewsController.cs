using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Food.Models;

namespace Food.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly FoodContext _db;

    public ReviewsController(FoodContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Review> model = _db.Reviews.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Review thisResturant = _db.Reviews.FirstOrDefault(reviews => reviews.Id == id);
      return View(thisResturant);
    }
  }
}