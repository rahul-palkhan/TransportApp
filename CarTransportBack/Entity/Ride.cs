using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarTransportBack.Entity
{
    public class Ride
    {
        [Key]
        public int TripId { get; set; }
        [ForeignKey("car")]
        public int CarId { get; set; }
        public Car? car { get; set; }
        [ForeignKey("user")]
        public int UserId { get; set; }
        public User? user { get; set; }
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        public int NoOfSeats { get; set; }
        public bool isCompleted { get; set; }
    }
}
