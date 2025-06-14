using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class List
    {
        public int Id { get; set; }
        public decimal Score { get; set; }

        [Required]
        public string? Title { get; set; }

    }
}
