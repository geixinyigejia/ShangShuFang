using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//
using WebAPIDemo2_BookService.Models;
using System.Threading.Tasks;

//
using System.Web.Http.Description;

namespace WebAPIDemo2_BookService.Controllers
{
    public class AuthorsController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();


        public IQueryable<Author> GetAuthors()
        {
            return db.Authors;
        }

         [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> GetAuthor(int id)
        {
            Author author = await db.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
