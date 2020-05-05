using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCRUD.Models
{
    public class BookDetail
    {
        [Key]
        public int BKID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string BookName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")] 
        public string Author { get; set; }

   
    }
}
