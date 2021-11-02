using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLogic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMP1005_WebAPICalculatorAssignment1_A00236910.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorSubtractController : ControllerBase
    {

        //this method accepts two double data type numbers to return the result by subtracting second number from first number from CalculatorLogic shared library subtraction method
        [HttpGet]
        public double Subtract([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Subtraction(num1, num2);
        }
    }
}
