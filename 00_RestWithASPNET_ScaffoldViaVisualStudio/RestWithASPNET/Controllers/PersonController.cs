using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult Sum(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        [HttpGet("subtraction/{firstnumber}/{secondnumber}")]
        public IActionResult Subtraction(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var subtraction = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondnumber);
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        [HttpGet("multiplication/{firstnumber}/{secondnumber}")]
        public IActionResult Multiplication(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var multiplication = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondnumber);
                return Ok(multiplication.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        [HttpGet("division/{firstnumber}/{secondnumber}")]
        public IActionResult Division(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var division = ConvertToDecimal(firstnumber) / ConvertToDecimal(secondnumber);
                return Ok(division.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        [HttpGet("mean/{firstnumber}/{secondnumber}")]
        public IActionResult Mean(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var mean = (ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        [HttpGet("square-root/{firstnumber}")]
        public IActionResult Squareroot(string firstnumber)
        {
            if (IsNumeric(firstnumber))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstnumber));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid  Result");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;

        }


    }
}
