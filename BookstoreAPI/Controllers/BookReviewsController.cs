using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BookstoreAPI.Models;

namespace BookstoreAPI.Controllers
{
    public class BookReviewsController : ApiController
    {
        private BookstoreAPIContext db = new BookstoreAPIContext();

        // GET: api/BookReviews
        public IQueryable<BookReview> GetBookReviews()
        {
            return db.BookReviews;
        }

        // GET: api/BookReviews/5
        [ResponseType(typeof(BookReview))]
        public async Task<IHttpActionResult> GetBookReview(int id)
        {
            BookReview bookReview = await db.BookReviews.FindAsync(id);
            if (bookReview == null)
            {
                return NotFound();
            }

            return Ok(bookReview);
        }

        // PUT: api/BookReviews/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBookReview(int id, BookReview bookReview)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookReview.Id)
            {
                return BadRequest();
            }

            db.Entry(bookReview).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/BookReviews
        [ResponseType(typeof(BookReview))]
        public async Task<IHttpActionResult> PostBookReview(BookReview bookReview)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookReviews.Add(bookReview);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bookReview.Id }, bookReview);
        }

        // DELETE: api/BookReviews/5
        [ResponseType(typeof(BookReview))]
        public async Task<IHttpActionResult> DeleteBookReview(int id)
        {
            BookReview bookReview = await db.BookReviews.FindAsync(id);
            if (bookReview == null)
            {
                return NotFound();
            }

            db.BookReviews.Remove(bookReview);
            await db.SaveChangesAsync();

            return Ok(bookReview);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookReviewExists(int id)
        {
            return db.BookReviews.Count(e => e.Id == id) > 0;
        }
    }
}