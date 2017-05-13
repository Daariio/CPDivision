using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CPDivision.Api.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IEnumerable<Person> Persons()
        {
            return new List<Person>
            {
                new Person {Age = 21, Name = "Jan", Surname = "Kowalski"},
                new Person {Age = 43, Name = "Kazimierz", Surname = "Nowak"},
                new Person {Age = 18, Name = "Adrian", Surname = "Ptak"}

            };
        }

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; } 
        }
    }
}
