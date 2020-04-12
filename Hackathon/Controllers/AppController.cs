using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Hackathon.Context;
using Hackathon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public AppController(DatabaseContext context)
        {
            _context = context;
        }
        // GET: api/App
        [HttpGet]
        public void Get()
        {            
        }

        // POST: api/App
        [HttpPost]
        public async Task<string> Post([FromBody] SimptomiDTO simptomi)
        {

            var testJSON = new TestJSON()
            {
                model = "model/5e926c194f6bfd2dd000438b",
                input_data = simptomi
            };

            var url = "https://bigml.io/andromeda/prediction?username=zergona&api_key=f8bdce912a3840c9da94af7d5cc7fc0d65647b68";

            var dataAsString = JsonConvert.SerializeObject(testJSON);
            HttpClient client = new HttpClient();

            var result = client.PostAsync(url, new StringContent(dataAsString, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync();

            var parsedObject = JObject.Parse(result.Result);

            var probability = parsedObject["confidence"].ToString();

            return probability;
        }

        // PUT: api/App/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    }
}
