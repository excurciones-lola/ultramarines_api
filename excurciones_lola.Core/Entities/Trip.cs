using System.ComponentModel.DataAnnotations;

namespace MyApp.Core.Entities
{
    public class Trip
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public required string Title { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        public required string Duration { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Deposit { get; set; }

        public bool CreditCard { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
