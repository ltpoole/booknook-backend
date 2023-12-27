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
        public IActionResult GetReviewsByBookId(string bookId)
        {
            try
            {
                var reviews = _context.Reviews.Select(r => new BookDetailsDto
                {
                    Reviews = new List<ReviewWithUserDto>
                    {
                        new ReviewWithUserDto
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
                        }
                    },
                    AverageRating = 0,
                    IsFavorited = false,
                }).ToList();

                return StatusCode(200, reviews);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
    
}
