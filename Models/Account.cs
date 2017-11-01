using System.ComponentModel.DataAnnotations;
namespace scaffold.Models
{
    public class Account : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public int balance { get; set; }
        public int userId { get; set; }
        public User User { get; set; }
    }
}