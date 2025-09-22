﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } //PK
        [Required(ErrorMessage ="Title is Required")]
        [StringLength(50,MinimumLength = 3)] //3 : 50 chars
        //[MaxLength(50,ErrorMessage ="Max Length is 50"), MinLength(3)] //3 : 50 chars
        public string Title{ get; set; }
        [Required(ErrorMessage ="content is required")]
        [MaxLength(300),MinLength(10)]
        public string Content{ get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Relations
        //1.belong to one category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //2.one user create post
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        ICollection<Comment> comments { get; set; } = new List<Comment>();
    }
}