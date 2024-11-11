// Models/ComputerPart.cs
using System.ComponentModel.DataAnnotations;

namespace ComputerPartsStore.Models
{
    public class ComputerPart
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        [Range(0.01, 10000)]
        public decimal Price { get; set; }
        
        [Required]
        public int Stock { get; set; }
    }
}