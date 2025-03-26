using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Pages.Albums;

public class CreateModel : PageModel
{
    private readonly ChinookDbContext _context;

    public CreateModel(ChinookDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Album Album { get; set; } = new();

    public SelectList ArtistList { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        var artists = await _context.Artists.OrderBy(a => a.Name).ToListAsync();
        ArtistList = new SelectList(artists, "ArtistId", "Name");
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            var artists = await _context.Artists.OrderBy(a => a.Name).ToListAsync();
            ArtistList = new SelectList(artists, "ArtistId", "Name");
            return Page();
        }

        Album.Title = Album.Title?.Trim();

        _context.Albums.Add(Album);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index");
    }
}
