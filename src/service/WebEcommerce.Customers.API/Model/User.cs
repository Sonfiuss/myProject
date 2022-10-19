using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace  service.WebEcommerce.Customers.API.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail{ get; set; }
        public string Phone{ get; set; }
        public string Password{ get; set; }
        public string Email{ get; set; }
        [Required]
        public string UrlAvatar{ get; set; }
        public DateTime? Date{ get; set; }
        [Required]
        public bool Genders{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Status{ get; set; }

    }
}