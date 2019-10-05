using ExceptionFilters.Controllers;
using ExceptionFilters.Exceptions;
using ExceptionFilters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilters.Services
{
    public class BookService : IBookService
    {

        List<Book> books = new List<Book>() { new Book() { Id = 1, Name = "C#" },
                                              new Book() { Id = 3, Name = "Javascript" } };

        public Book Get(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if ( book == null )
                throw new EntityNotFoundException(nameof(Book), id);

            return book;
        }
    }
}
