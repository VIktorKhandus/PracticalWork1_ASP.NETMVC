using System.ComponentModel.DataAnnotations;

namespace FoodStore.Models
{
    public class Manufacturers
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
    }
}
