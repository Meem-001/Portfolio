using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    // GET / — the single-page portfolio
    public IActionResult Index()
    {
        return View(PortfolioData.Current);
    }

    public IActionResult Error() => Content("Something went wrong.");
}
