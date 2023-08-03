using P517_collections.Enums;
using P517_collections.Exceptions;
using P517_collections.Interfaces;
using P517_collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_collections.Services
{
     class LibraryManager:ILibraryManager
    {
        List<Book> books;
        public LibraryManager()
        {
            books = new List<Book>();   
        }
        public List<Book> Books => books;
        public void Add(Book book)
        {
     
            if (Books.Find(b => b.Name.ToUpper() == book.Name.ToUpper()) != null)
            {
                throw new SameBookAlreadyAddedException("Bu adda kitab movcuddur");
            }
            else
            {
                Books.Add(book);
            }
        }
        public List<Book> Filter(string author, GenreType genre)
        {
            List<Book> books = Books.FindAll(book=>book.Author.ToUpper()==author.ToUpper() && book.Genre == genre);
            return books;
        }
        public List<Book> Search(string str)
        {
            List<Book> books = Books.FindAll(book => book.Name.ToUpper().Contains(str.ToUpper()) ||
            book.Author.ToUpper().Contains(str.ToUpper()) ||
            book.PageCount.ToString().Contains(str.ToUpper()) ||
            Enum.GetName(typeof(GenreType), book.Genre).Contains(str));
            return books;
            
        }
        public Book ShowInfo(string name)
        {
            //Find
            Book book = Books.Find(book => book.Name.ToUpper() == name.ToUpper());
            if (book == null)
            {
                throw new BookNotFoundException("Axtardiginiz kitab tapilmadi");
            }
            else
            {
                return book;
            }
        }
    }
}
