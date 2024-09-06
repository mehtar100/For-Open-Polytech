using Microsoft.AspNetCore.Mvc;
using Rakesh.Models;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Rakesh.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompaniesController : Controller
    {
        private readonly ILogger<CompaniesController> _logger;

        public CompaniesController(ILogger<CompaniesController> logger)
        {
            _logger = logger;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Company));
                FileStream xmlStream = new FileStream($"xml-api/{id}.xml", FileMode.Open);
                var result = xml.Deserialize(xmlStream);
                Console.WriteLine(result);

                // XElement bookfromFile = XElement.Load(($"xml-api/{id}.xml");

                return Ok(result);
            }
            catch (Exception)
            {

                return NotFound();
            }

            



        }
    }
}
