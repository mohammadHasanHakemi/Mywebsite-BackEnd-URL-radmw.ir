using System.ComponentModel.DataAnnotations;

namespace MyMvcProject.Models
{
    public class Music
    {
    public int Id { get; set; }
    public required string Name { get; set; } // یا string? Name اگر می‌تونه null باشه
    public required string Property { get; set; }
    public required int AlbumNumber { get; set; }
    public required string PosterPath { get; set; }
    public required string MusicPath { get; set; }
    public required int View { get; set; }
    public required int Like { get; set; }
    public required string Time { get; set; }
    }
}
