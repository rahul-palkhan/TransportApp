﻿using System.ComponentModel.DataAnnotations;

namespace CarTransportBack.Entity
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string? Start { get; set; }
        [Required]
        public string? End { get; set; }
        public String DriverName { get; set; }
        public int Capacity { get; set; }
        public DateTime Timing { get; set; }
    }
}
