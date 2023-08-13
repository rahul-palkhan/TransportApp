using CarTransportBack.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarTransportBack.DTO
{
    public class UpcomingsRides
    {
        public string DriverName { get; set; }
        public int UserId { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int NoOfSeats { get; set; }
        public bool isCompleted { get; set; }
    }
}
