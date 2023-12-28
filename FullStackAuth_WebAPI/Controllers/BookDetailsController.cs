using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<BookDetailsController>
        [HttpGet("{bookId}")]
        public IActionResult GetBookDetails(string bookId)
        {
            var reviews = _context.Reviews.Where(r => r.BookId == bookId).Select(r => new ReviewWithUserDto
            {
                Id = r.Id,
                BookId = r.BookId,
                Text = r.Text,
                Rating = r.Rating,
                User = new UserForDisplayDto
                {
                    Id = r.User.Id,
                    FirstName = r.User.FirstName,
                    LastName = r.User.LastName,
                    UserName = r.User.UserName,
                }
            }).ToList();

            var averageRating = reviews.Any() ? reviews.Average(r => r.Rating) : 0;

            var isFavorited = _context.Favorites.Any(f => f.BookId == bookId);

            var bookDetailsDto = new BookDetailsDto
            {
                Reviews = reviews,
                AverageRating = averageRating,
                IsFavorited = isFavorited,
            };

            return StatusCode(200, bookDetailsDto);
        }
    }
    
}
