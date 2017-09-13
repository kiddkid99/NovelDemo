using System.ComponentModel.DataAnnotations;

namespace NovelDemo.Web.Application.ViewModel
{
    public class AuthorEditViewModel
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public bool Status { get; set; }
    }
}