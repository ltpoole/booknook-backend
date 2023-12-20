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
        public IActionResult Get(string bookId)
        {
            var review = _context.Reviews.Include(r => r.Id).FirstOrDefault(r => r.BookId == bookId);
            if (review == null)
            {
                return NotFound();
            }
            var bookDetailsDto = new BookDetailsDto
            {
                Reviews = new List<ReviewWithUserDto>
                { 
                    new ReviewWithUserDto 
                    {
                        Id = review.Id,
                        BookId = review.BookId,
                        Text = review.Text,
                        Rating = review.Rating,
                        User = new UserForDisplayDto
                        {
                            Id = "h",
                            FirstName = "h",
                            LastName = "j",
                            UserName = "k"
                        }
                    } 
                },
                AverageRating = 0,
                IsFavorited = false,
            };
            return StatusCode(200, bookDetailsDto);
        }
    }
}
