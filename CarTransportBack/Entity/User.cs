using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarTransportBack.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string? UserName { get; set; }
        public string? Mobile { get; set; }
        public int CarOwner { get; set; }
        public string passcode { get; set; }
    }
}
