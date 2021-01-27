using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpBook.Models
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        
        public class BookManager
        {
            public static List<Book> GetBooks()
            {
                var books = new List<Book>();
                books.Add(new Book { BookId = 1, Title = "A", Author = "Leesin", CoverImage = "Assets/1.png" });
                books.Add(new Book { BookId = 2, Title = "B", Author = "Leesin", CoverImage = "Assets/2.png" });
                books.Add(new Book { BookId = 3, Title = "C", Author = "Leesin", CoverImage = "Assets/3.png" });
                books.Add(new Book { BookId = 4, Title = "D", Author = "Leesin", CoverImage = "Assets/4.png" });
                books.Add(new Book { BookId = 5, Title = "E", Author = "Leesin", CoverImage = "Assets/5.png" });
                books.Add(new Book { BookId = 6, Title = "F", Author = "Leesin", CoverImage = "Assets/6.png" });
                books.Add(new Book { BookId = 7, Title = "G", Author = "Leesin", CoverImage = "Assets/7.png" });
                books.Add(new Book { BookId = 8, Title = "H", Author = "Leesin", CoverImage = "Assets/8.png" });
                books.Add(new Book { BookId = 9, Title = "I", Author = "Leesin", CoverImage = "Assets/9.png" });
                books.Add(new Book { BookId = 10, Title = "J", Author = "Leesin", CoverImage = "Assets/10.png" });
                books.Add(new Book { BookId = 11, Title = "K", Author = "Leesin", CoverImage = "Assets/11.png" });
                books.Add(new Book { BookId = 12, Title = "M", Author = "Leesin", CoverImage = "Assets/12.png" });
                books.Add(new Book { BookId = 13, Title = "N", Author = "Leesin", CoverImage = "Assets/13.png" });

                return books;



            }

        }
        
    }
}
