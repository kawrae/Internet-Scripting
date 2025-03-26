using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Pages.Albums;

public class EditModel : PageModel
{
    private readonly ChinookDbContext _context;

    public EditModel(ChinookDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Album Album { get; set; } = new();

    public SelectList ArtistList { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Album = await _context.Albums.Include(a => a.Artist)
                                     .FirstOrDefaultAsync(a => a.AlbumId == id);

        if (Album == null)
        {
            return NotFound();
        }

        var artists = await _context.Artists.OrderBy(a => a.Name).ToListAsync();
        ArtistList = new SelectList(artists, "ArtistId", "Name", Album.ArtistId);

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            var artists = await _context.Artists.OrderBy(a => a.Name).ToListAsync();
            ArtistList = new SelectList(artists, "ArtistId", "Name", Album.ArtistId);
            return Page();
        }

        _context.Attach(Album).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Albums.Any(a => a.AlbumId == Album.AlbumId))
            {
                return NotFound();
            }

            throw;
        }

        return RedirectToPage("Index");
    }
}
