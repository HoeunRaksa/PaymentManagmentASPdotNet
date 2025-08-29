using PaymentManagementAPI.Enum;
using System.ComponentModel.DataAnnotations;

namespace PaymentManagementAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public required string fistname { get; set; }

        [Required, MaxLength(30)]
        public required string lastname { get; set; }

        [Required, MaxLength(50)]
        public required string email { get; set; }

        [Required, MaxLength(50)]
        public required string password { get; set; }

        [Required, MaxLength(30)]
        public required string phone { get; set; }

        [MaxLength(30)]
        public Role? Role { get; set; }  // Nullable enum

        [MaxLength(15)]
        public string? Status { get; set; } // Nullable string
    }
}
