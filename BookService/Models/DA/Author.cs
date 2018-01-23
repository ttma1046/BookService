using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookService.Models.DA
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}