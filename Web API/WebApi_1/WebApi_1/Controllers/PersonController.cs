using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    [RoutePrefix("api/User")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1, Personname="Yudhishter",Designation="VicePresident",Gender="Male"},
             new Person{Id=2, Personname="Bheem",Designation="Developer",Gender="Male" },
              new Person{Id=3, Personname="Draupadi",Designation="Quality",Gender="Female"},
               new Person{Id=4, Personname="Uthara",Designation="Tester",Gender="Female"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person>Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("Bymessage")]
        public HttpResponseMessage GetAllPersons()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
            // response.Content = new StringContent("Hello All");
            return response;
        }
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult PersonById(int pid)
        {
            var person = personlist.Find(p => p.Id == pid);
            if(person ==null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet]
        [Route("GetName")]

        public IHttpActionResult GetPersonByName(int pid)
        {
            string uname = personlist.Where(p => p.Id == pid).SingleOrDefault()?.Personname;
            if(uname==null)
            {
                return NotFound();
            }
            return Ok(uname);
        }

        [HttpGet]
        [Route("allmale")]
        //get all male persons
        public HttpResponseMessage LoadAllMaleEmp()
        {
            var persons = personlist.Where(p => p.Gender == "Male").ToList();
            return Request.CreateResponse(HttpStatusCode.OK, persons);
        }

        [HttpGet]
        [Route("allfemale")]
        //get all female persons
        public HttpResponseMessage LoadAllFemaleEmp()
        {
            var persons = personlist.Where(p => p.Gender == "Female").ToList();
            return Request.CreateResponse(HttpStatusCode.OK, persons);
        }

        //post
        [HttpPost]
        [Route("AllPost")]
        public List<Person>PostAll([FromBody] Person person)
        {
            personlist.Add(person);
            return personlist;
        }

        [HttpPost]
        [Route("personpost")]
        public void Personpost([FromUri]int Id, string name, string desig)
        {
            Person person = new Person();
            person.Id = Id;
            person.Personname = name;
            person.Designation = desig;
            personlist.Add(person);
        }

        [HttpPut]
        [Route("updperson")]
        public void Put(int pid,[FromUri] Person p)
        {
            personlist[pid - 1] = p;
        }

        [HttpDelete]
        [Route("delperson")]
        public void Delete(int pid)
        {
            personlist.RemoveAt(pid - 1);
        }
    }
}
