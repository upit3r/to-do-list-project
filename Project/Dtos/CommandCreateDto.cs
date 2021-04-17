using System.ComponentModel.DataAnnotations;
namespace Project.Dtos{
    public class CommandCreateDto{
        [Required]
        public string Heading { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public string Signature { get; set; }

    }
}