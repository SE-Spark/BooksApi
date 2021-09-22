using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ED_Project.Models;
using ED_Project.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ED_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRespository _bookRespository = null;
        public BookController()
        {
            _bookRespository = new BookRespository();
        }
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {
            return _bookRespository.GetAllBooks();
        }

        [HttpGet("{id}")]
        public BookModel GetBook(int id)
        {
            return _bookRespository.GetBookById(id);
        }
        [Route("search")]
        [HttpGet]
        public List<BookModel> SearchBook(string title, string author)
        {
            return _bookRespository.SearchBook(title, author);
        }

    }
}