using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models;

public class Track
{
    [Key]
    public int TrackId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [ForeignKey("AlbumId")]
    public int AlbumId { get; set; }

    public Album? Album { get; set; }
}
