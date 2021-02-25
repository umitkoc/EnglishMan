using System.Collections.Generic;

namespace EnglishMan.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Products { get; set; }
    }
}