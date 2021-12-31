using APITest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace APITest.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class ApiTestController : ControllerBase
    {
        [HttpGet("GetAll")]                                 //Routing Endpunkt .../getall
        public IActionResult GetAll()
        {
            int input = 5;
            int result = input + 2;

            return Ok($"The default value calculated by the API is: " + result);
        }

        //[HttpGet("GetResult")]                                 //Routing Endpunkt .../getall
        //public IActionResult GetResult(int input)
        //{
        //    input = 5;
        //    int result = input + 2;

        //    return Ok($"You sent a value of {input} to the API. The API calculated a result of: " + result);
        //}

        [HttpPost("GetResult")]                                 //Routing Endpunkt .../getall
        public IActionResult GetResult(Input input)
        {
            int result = input.Value + 2;

            return Ok($"You sent a value of {input.Value} to the API. The API calculated a result of: " + result);
        }

        [HttpPost("GetCircleArea")]                                 //Routing Endpunkt .../getall
        public IActionResult GetCircleArea(Input input)
        {
            Circle circle = new Circle(input.Value);

            double result = circle.Circumference;

            return Ok($"You sent a value of {input.Value} to the API. The API calculated a result of: " + result);
        }


    }
}
