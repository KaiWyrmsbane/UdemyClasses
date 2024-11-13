using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CodePulse.API.Controllers
{
    // this would be the url for reaching this controller
    // localhost:(port#) not sure will have to find out later
    // https://localhost:xxxx/api/cetegories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        //building a constructor so we can inject the DbContext class
        public CategoriesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //lets define the put for this controller
        [ProducesResponseType(200)]
        [Produces("application/json")]
        //define the route
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //This apparently is good pratice more than anything
            //apparently we don't want to expose the domain models since they can hold sensitive information
            //but we can show DTO's
            //DTO (Data transfer model)
            //Map DTO to domain model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            //The Id is populated by EFCore
            //(I will eventually do away with this since I want to learn how to write my own migrations and add them to the DB)
            //I plan on using an ORM in the near future which will be Oracle
            //Domain model to DTO
            var response = new CategoryDto
            {
                id = category.id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);
            //C:\Users\james\Documents\Programming\UdemyClasses\ANGULAR and ASP.NET Core REST API\CodePulse\API\CodePulse.API\CodePulse.API\CodePulse.API.csproj
        }

        //started following an example of what we do at work
        [ProducesResponseType(200)]
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetCategories(CreateCategoryRequestDto request)
        {
           string stuff = "hello world";
           return Ok(stuff);
        }
    }
}
