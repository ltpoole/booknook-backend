using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//namespace FullStackAuth_WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
    //public class BookDetailsController : ControllerBase
    //{
    //    private readonly ApplicationDbContext _context;

    //    public BookDetailsController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    [HttpGet("id")]
    //    public IActionResult GetBookDetails(string bookId)
    //    {
    //        try
    //        {
    //            var review = _context.Reviews.Include(r => r.BookId).FirstOrDefault(r => r.BookId == bookId);
    //            if (review == null) 
    //            {
    //                return NotFound();
    //            }
               
                    
    //            };
    //            return StatusCode(200);
    //        }
    //        catch (Exception ex)
    //        {
    //            return StatusCode(500, ex.Message);
    //        }
//    //    }
//    //}
//}
