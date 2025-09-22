using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Models
{
    public class User
    {
        [Key]
        //public Guid Id { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage ="Username is required")]
        [StringLength(50,MinimumLength =3)]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100),EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Password is required")]
        [StringLength(50 ,MinimumLength =4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Relations
        ICollection<Post> Posts { get; set; }   = new List<Post>();
        ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
