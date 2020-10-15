using System.ComponentModel.DataAnnotations;

namespace AbpODataDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}