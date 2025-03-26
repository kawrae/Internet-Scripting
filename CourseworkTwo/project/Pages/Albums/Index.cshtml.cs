using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Pages.Albums;

public class IndexModel : PageModel
{
    private readonly ChinookDbContext _context;

    public IndexModel(ChinookDbContext context)
    {
        _context = context;
    }

    public IList<Album> Albums { get; set; } = new List<Album>();

    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    public async Task OnGetAsync()
    {
        var query = _context.Albums.Include(a => a.Artist).AsQueryable();

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            var lowered = SearchTerm.ToLower();
            query = query.Where(a =>
                a.Title.ToLower().Contains(lowered) ||
                a.Artist!.Name.ToLower().Contains(lowered));
        }

        Albums = await query.OrderBy(a => a.Title).ToListAsync();
    }

}
