using System.ComponentModel.DataAnnotations;

namespace Douana.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}