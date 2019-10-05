using ExceptionFilters.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilters.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class BooksController:ControllerBase 
    {
        private readonly IBookService _books;

        public BooksController( IBookService books  )
        {
            this._books = books;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Book> Get(int id)
        {
            var book = _books.Get(id);

            if (book == null ) return NotFound();

            return Ok(book);


        }


    }

}
