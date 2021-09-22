using ED_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ED_Project.Respository
{
    public class BookRespository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }
        public BookModel GetBookById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return Datasource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
        private List<BookModel> Datasource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id=1,Title="MVC",Author="Sami"},
                new BookModel(){Id=2,Title="NET",Author="Rael"},
                new BookModel(){Id=3,Title="Java",Author="Sami"},
                new BookModel(){Id=4,Title="PHP",Author="Sami"},
                new BookModel(){Id=5,Title="Html",Author="Kimau"},
                new BookModel(){Id=6,Title="CSS",Author="Dany"},
            };
        }

    }
}
