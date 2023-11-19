using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MvcBlazorSSR.Components;

namespace MvcBlazorSSR.Controllers;

public class HomeController : Controller
{
    public RazorComponentResult<HelloWorld> Index() => new();
    
    [HttpGet("/current-date")]
    public RazorComponentResult<CurrentDate> CurrentDate() => new();
}
