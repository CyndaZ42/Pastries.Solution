using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pastries.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pastries.Controllers
{
  public class TreatController : Controller
  {
    private readonly PastriesContext _db;

    public TreatController(PastriesContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}