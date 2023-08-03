using P517_collections.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_collections.Models
{
     class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public GenreType Genre { get; set; }
        public Book(string name, string author, int pageCount, GenreType genreType)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Genre = genreType;
        }
    }
}
