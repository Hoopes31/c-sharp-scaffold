using System.ComponentModel.DataAnnotations;

namespace scaffold.Models
{
    public class LoginViewModel : BaseEntity
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}
    }
}