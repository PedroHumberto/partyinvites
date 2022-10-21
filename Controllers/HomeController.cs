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
        ViewResult myView = View();
        if(ModelState.IsValid){ // The razor can acces to the datails of any validation erros associeted with the request.

            Repository.AddResponse(guestResponse);
            myView = View("Thanks", guestResponse);
        }else myView = View();

        return myView;
    }

    public ViewResult ListResponce(){
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }

}
