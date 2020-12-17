using EF.Library;
using EF.Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EFController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public EFController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/books")]
        public IEnumerable<Book> GetBooks()
        {
            MediaContext context = new MediaContext();
            var books = context.Books.ToList();
            return books;
        }
    }
}
