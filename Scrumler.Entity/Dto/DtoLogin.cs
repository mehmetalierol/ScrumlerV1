using System.ComponentModel.DataAnnotations;

namespace Scrumler.Entity.Dto
{
    public class DtoLogin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}