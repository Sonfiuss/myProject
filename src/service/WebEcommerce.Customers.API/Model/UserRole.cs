using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace service.WebEcommerce.Customers.API.Model
{
    public class UserRole
    {
        [Key]

        public int UserId { get; set; }
        public User User { get; set; }
        
        [Key]
        public int RoleId { get; set; }
        public Role role { get; set; }
    }
}