using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstSide.Models
{
    public class BooksFactory
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Author = "Э. Юдковский",
                Name = "\"Тройной контакт\""

            });
            books.Add(new Book()
            {
                Author = "А. П. Чехов",
                Name = "\"Вишневый сад\""

            });
            books.Add(new Book()
            {
                Author = "Дж. К. Роулинг",
                Name = "\"Гарри Поттер\""

            });
            return books;

        }
    }
}