using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FilmDetails;


namespace webApp.Pages
{
    public class InsertActor : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            Actor insActor = new Actor()
            {
                FirstName = Request.Form["tbxFirstName"],
                LastName = Request.Form["tbxLastName"],
            };
            FilmsDatabase db = new FilmsDatabase();
            db.Actors!.Add(insActor);
            db.SaveChanges();

            return Redirect("~/Index");
        }
    }
}