    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR_System.Models
{
    [Table("Article")]
    public class Article
    {
        [Key]
        public int artID { get; set; }
        public string artDesc { get; set; }
        public string artTitle { get; set; }
    }
} 