using System.ComponentModel.DataAnnotations;

namespace MyMvcProject.Models
{
    public class Album
    {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string PosterPath { get; set; }
    }
}
