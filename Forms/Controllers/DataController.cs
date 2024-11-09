using Microsoft.AspNetCore.Mvc;
using Ankieta.Models;
public class DataController : Controller
{
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(Data Data)
    {
        if (ModelState.IsValid)
        {
            return View("Resault", Data);
        }
        return View();
    }

    public IActionResult Resault(Data Data)
    {
        return View(Data);
    }
}
