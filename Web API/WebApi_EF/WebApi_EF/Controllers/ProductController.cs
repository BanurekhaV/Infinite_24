using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_EF.Models;

namespace WebApi_EF.Controllers
{
    public class ProductController : ApiController
    {
        TrainingDBEntities db = new TrainingDBEntities();

        //Get

        public IEnumerable<Product>Get()
        {
            return db.Products.ToList();
        }

        public Product Get(int Id)
        {
            return db.Products.FirstOrDefault(p => p.ProductId == Id);
        }

        //Post
        [HttpPost]
        public IHttpActionResult PostNewProduct([FromBody] Product p)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Validation Failed");
            }
            db.Products.Add(new Product()
            {
                ProductId = p.ProductId,
                Productname = p.Productname,
                Price = p.Price,
                QuantityAvailable = p.QuantityAvailable,
            });
            db.SaveChanges();
            return Ok("Success");
        }

        //put
        public IHttpActionResult Put([FromBody] Product p)
        {
            if(ModelState.IsValid)
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Entity Updated");
        }
    }
}
