using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//
using WebAPIDemo2_BookService.Models;
using System.Threading.Tasks;
using System.Web.Http.Description;

using System.Data.Entity;


namespace WebAPIDemo2_BookService.Controllers
{
    public class BooksController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();

        public IQueryable<BookDTO> GetBooks()
        {
            var books=from b in db.Books select new BookDTO()
            {
                Id =b.Id,
                Title=b.Title,
                AuthorName=b.Author.Name
            };
            return books;
        }


         [ResponseType(typeof(BookDetailDTO))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            var book = await db.Books.Include(b => b.Author).Select(b => new BookDetailDTO() 
            {
                Id = b.Id,
                Title = b.Title,
                Year = b.Year,
                Price = b.Price,
                AuthorName = b.Author.Name,
                Genre = b.Genre
            }).SingleOrDefaultAsync( b=>b.Id==id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);

        }

    }
}
