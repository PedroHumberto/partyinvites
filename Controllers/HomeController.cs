using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(){
        return View();
    }

    //Second Action view
    [HttpGet]
    public ViewResult RsvpForm(){
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse){
        Repository.AddResponse(guestResponse);
        return View("Thanks", guestResponse);
    }

    public ViewResult ListResponce(){
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }

}
