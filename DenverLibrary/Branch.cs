using System;

namespace DenverLibrary
{
    public class Branch
    {
        public string Name { get; set; }
        //public List<Book> Books { get; set; } = new List<Book>();
        public List<Book> Books { get; set; }

        public Branch(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<string> AllAuthors()
        {
            var authors = new List<string>();
            foreach (var book in Books)
            {
                authors.Add(book.Author);
            }
            return authors;
        }
    }
}
