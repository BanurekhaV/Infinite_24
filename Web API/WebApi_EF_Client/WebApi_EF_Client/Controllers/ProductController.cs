using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using WebApi_EF_Client.Models;
using System.Threading.Tasks;


namespace WebApi_EF_Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //action method to consume web api product/get

        public ActionResult Display()
        {
            IEnumerable<MVCProductModel> productlist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44303/api/");
                var responsetalk = webclient.GetAsync("product");
                responsetalk.Wait();
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    productlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    productlist = Enumerable.Empty<MVCProductModel>();
                    ModelState.AddModelError(string.Empty, "Something went wrong.. Try later");
                }
                return View(productlist);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCProductModel mvcprd)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44303/api/");
                var posttalk = webclient.PostAsJsonAsync<MVCProductModel>("product", mvcprd);
                posttalk.Wait();
                var dataresult = posttalk.Result;
                if (dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
                ModelState.AddModelError(string.Empty, "Insertion Failed. Try later");
                return View(mvcprd);
            }
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            if (Id == 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            MVCProductModel product = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44303/api/");
                var edittalk = webclient.GetAsync("product/" + Id).Result;
                if (edittalk.IsSuccessStatusCode)
                {
                    var resultdata = edittalk.Content.ReadAsStringAsync().Result;
                    product = JsonConvert.DeserializeObject<MVCProductModel>(resultdata);
                }
                else
                    ModelState.AddModelError(string.Empty, "Some Error..");
            }
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Edit([Bind(Include ="ProductId,ProductName,Price,QuantutyAvailable")] MVCProductModel p)
        {
            if (ModelState.IsValid)
            {
                using (var webclient = new HttpClient())
                {
                    webclient.BaseAddress = new Uri("https://localhost:44303/api/");
                    var response = await webclient.PutAsJsonAsync("product/edit", p);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Display");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Please try later..");
                    }
                }
                return RedirectToAction("Index");
            }
            return View(p);
        }
            
    }
}