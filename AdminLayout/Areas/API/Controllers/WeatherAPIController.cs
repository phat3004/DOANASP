using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using static AdminLayout.Areas.Admin.Models.WeatherViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminLayout.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherAPIController : ControllerBase
    {
        // GET: api/<WeatherAPIController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public string GetWeather(string city)
        {
            string APIKey = "a73508240f1e345544741d9e86bd032a";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + APIKey;
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url); //Lấy chuỗi json (API) từ web-api về
                RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);//Hủy mã hóa chuỗi json mới lấy về

                ResultViewModel rslt = new ResultViewModel(); //Tạo đối tượng Result để gán giá trị trong chuỗi json

                rslt.Country = weatherInfo.sys.country;
                rslt.City = weatherInfo.name;
                rslt.Lat = Convert.ToString(weatherInfo.coord.lat);
                rslt.Lon = Convert.ToString(weatherInfo.coord.lon);
                rslt.Description = weatherInfo.weather[0].description;
                rslt.Humidity = Convert.ToString(weatherInfo.main.humidity);
                rslt.Temp = Convert.ToString(weatherInfo.main.temp);
                rslt.TempFeelsLike = Convert.ToString(weatherInfo.main.feels_like);
                rslt.TempMax = Convert.ToString(weatherInfo.main.temp_max);
                rslt.TempMin = Convert.ToString(weatherInfo.main.temp_min);
                rslt.WeatherIcon = weatherInfo.weather[0].icon;

                //Converting OBJECT to JSON String   
                var jsonstring = new JavaScriptSerializer().Serialize(rslt); //Chuyển đối tượng rslt thành chuỗi JSON

                //Return JSON string.  
                return jsonstring;
            }
        }
        // GET api/<WeatherAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WeatherAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WeatherAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
