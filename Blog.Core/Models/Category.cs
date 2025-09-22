﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Category name is required")]
        [MaxLength(50),MinLength(2)]
        public string Name { get; set; }

        //Relations
        //Many Posts
        public ICollection<Post> Posts { get; set; } = new List<Post>();


    }
}
