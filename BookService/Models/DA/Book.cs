using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Profile;

namespace BookService.Models.DA
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        // (Other properties)
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        // Virtual navigation property
        // public virtual Author Author { get; set; }
    }
}