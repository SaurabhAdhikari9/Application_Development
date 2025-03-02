using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet("name")]
        public List<string> GetName()
        {
            return Data.stringData;
        }

        [HttpPost("concat-string")]
        public string ConcatString(string a, string b)
        {
            return a + b;
        }

        [HttpDelete("remove-char")]
        public string RemoveChar(string name)
        {

            var isexist = Data.stringData.FirstOrDefault(p => p == name);
            if (isexist != null)
            {
                Data.stringData.Remove(name);
            }
            return name;
        }
    }
    public static class Data
    {
        public static List<string> stringData = new List<string>
        {
            "abc","xyz"
        };
    }
}
