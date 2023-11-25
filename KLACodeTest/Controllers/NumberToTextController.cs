
using KLACodeTest.Business;
using KLACodeTest.BusinessLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KLACodeTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberToTextController : Controller
    {
        private readonly INumberToWordsConverter _numberToWordsConverter;
        public NumberToTextController(INumberToWordsConverter numberToWordsConverter)
        {
            _numberToWordsConverter = numberToWordsConverter;
        }

        [HttpGet("ConvertNumberToWords")]
        public ActionResult<string> ConvertNumberToWords(double inputNumber)
        {
            if (inputNumber < 1000000000)
            {
                var result = _numberToWordsConverter.ConvertNumberToWords(inputNumber);
                return Ok(result);
            }
            else
            {
                return Ok("Number must not be greater than 999999999,99");
            }
        }
    }
}

