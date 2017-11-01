using System;
using System.ComponentModel.DataAnnotations;
namespace scaffold.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string first_name {get;set;}
        public string last_name {get;set;}
        public string email {get;set;}
        public string password {get;set;}
        public int AccountId { get; set; }
        public Account account { get; set; }
    }   
}