using P517_collections.Enums;
using P517_collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_collections.Interfaces
{
    internal interface ILibraryManager
    {
        List<Book> Books { get; }
        public void Add(Book book);
        public Book ShowInfo(string name);
        public List<Book> Search(string str);
        public List<Book> Filter(string author, GenreType genre);

    }
}
