using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLogic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMP1005_WebAPIAssignment1_A00236910.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //this method accepts two double data type numbers to return their sum from CalculatorLogic shared library addition method
        [HttpGet]
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Addition(num1, num2);
        }
    }
}