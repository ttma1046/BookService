using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models.DTO
{
    public class BookDetailDTO
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

        public string Genre { get; set; }
    }
}