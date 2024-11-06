using System.ComponentModel.DataAnnotations;
namespace ZooKeeping
{
    public class Animal
    {
        public Guid Id { get; set; }

        [Required, StringLength(50)]
        public string? Name { get; set; }

        [Required, StringLength(50)]
        public string? Gender { get; set; }

        [Required, StringLength(10)]
        public string? GivenName { get; set; }

        [Required, StringLength(50)]
        public string? Food { get; set; }

        [Required, StringLength(100)]
        public string? FeedingHour { get; set; }

        [Required]
        public int CageNumber { get; set; }
    }
}
