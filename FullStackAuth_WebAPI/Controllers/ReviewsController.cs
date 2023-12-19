using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using ZstdSharp.Unsafe;

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
           _context = context;
        }

        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Review data) 
        {
            try
            {
                string userId = User.FindFirstValue("id");

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }

                data.UserId = userId;

                _context.Reviews.Add(data);
            }
        }
    }
    
}
