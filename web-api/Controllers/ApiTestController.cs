using APITest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;
using Newtonsoft.Json;

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

            Result res = new Result(result);

            //string jsonOutput = JsonConvert.SerializeObject(res, Formatting.Indented);
            string jsonOutput = JsonConvert.SerializeObject(res);

            return Ok(jsonOutput);
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

            string jsonOutput = JsonConvert.SerializeObject(result);

            return Ok(jsonOutput);
        }

        [HttpPost("GetCircleArea")]                                 //Routing Endpunkt .../getall
        public IActionResult GetCircleArea(Input input)
        { 
        
            Circle circle = new Circle(input.Value);

            double result = circle.Circumference;

            string jsonOutput = JsonConvert.SerializeObject(result);

            return Ok(jsonOutput);
        }


    }
}
