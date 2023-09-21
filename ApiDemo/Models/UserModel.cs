using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Models
{
    public class UserModel
    {

        public int UserId { get; set; }
        
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

        public int  Age { get; set; }

        public string? Profession { get; set; }
    }
}
