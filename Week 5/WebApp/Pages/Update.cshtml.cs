using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FilmDetails;


namespace webApp.Pages
{
    public class UpdateActor : PageModel
    {

         // Property to hold the actor data
        public Actor? Actor { get; set; } = new Actor();
        // Handle GET request to load the form with actor data
        public IActionResult OnGet(int actorId)
        {
            FilmsDatabase db = new FilmsDatabase();

            // Fetch the actor from the database
            Actor = db.Actors!.SingleOrDefault(a => a.ActorID == actorId);

            if (Actor == null)
            {
                return NotFound($"Actor with ID {actorId} not found.");
            }

            return Page(); // Render the Razor page with the actor data
        }
        // Handle POST request to update the actor
        public IActionResult OnPost()
        {
            FilmsDatabase db = new FilmsDatabase();

            // Fetch actor ID from form submission
            int actorId = int.Parse(Request.Form["updtActorID"]!);

            // Retrieve the actor from the database
            Actor? existingActor = db.Actors!.SingleOrDefault(a => a.ActorID == actorId);

            if (existingActor != null)
            {
                // Update the actor's fields
                existingActor.FirstName = Request.Form["updtFirstName"];
                existingActor.LastName = Request.Form["updtLastName"];

                // Save the changes
                db.SaveChanges();
            }

            return Redirect("~/Index");
        }
    }
}
    
