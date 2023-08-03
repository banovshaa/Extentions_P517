using P517_collections.Enums;
using P517_collections.Interfaces;
using P517_collections.Models;
using P517_collections.Services;

ILibraryManager libraryManager = new LibraryManager();

Book book1 = new Book("Harry Potter","author1",100,GenreType.Fiction);
Book book2 = new Book("Hamlet", "author2", 200, GenreType.Science);
Book book3 = new Book("Kozmos", "author3", 100, GenreType.Detective);
Book book4 = new Book("book4", "author1", 130, GenreType.Fiction);
Book book5 = new Book("book5", "author5", 200, GenreType.Drama);

libraryManager.Add(book1);
libraryManager.Add(book2);  
libraryManager.Add(book3);
libraryManager.Add(book4);
libraryManager.Add(book5);

//libraryManager.Search("jhjh").ForEach(x =>
//Console.WriteLine($"{x.Name} {x.Author}")
//);

Book book = libraryManager.ShowInfo("Harry Potter");

//libraryManager.Filter("author1", GenreType.Fiction).ForEach(x => Console.WriteLine(x.Name));



