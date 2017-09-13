using System.ComponentModel.DataAnnotations;

namespace NovelDemo.Web.Application.ViewModel
{
    public class AuthorAddViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}