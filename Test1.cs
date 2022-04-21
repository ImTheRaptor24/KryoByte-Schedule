using System.ComponentModel.DataAnnotations;

namespace BlazorApp5
{
    public class Test1
    {
        [Required]
        [StringLength(80, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Phone number is too long.")]
        public string? Phone { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "Email is too long.")]
        public string? Email { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Machine Make is too long.")]
        public string? MachineMake { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "Machine Model is too long.")]
        public string? MachineModel { get; set; }


    }
}
