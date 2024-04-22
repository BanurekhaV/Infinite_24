﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository<Products> _prdrepo = null;

        public ProductsController()
        {
            _prdrepo = new ProductRepository<Products>();
        }
        // GET: Products
        public ActionResult Index()
        {
            var product = _prdrepo.GetAll();
            return View(product);            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products p)
        {
            if(ModelState.IsValid)
            {
                _prdrepo.Insert(p);
                _prdrepo.Save();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public ActionResult Edit(int Id)
        {
            var product = _prdrepo.GetById(Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products p)
        {
            if(ModelState.IsValid)
            {
                _prdrepo.Update(p);
                _prdrepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }

        public ActionResult Details(int id)
        {
            var product = _prdrepo.GetById(id);
            return View(product);
        }

        public ActionResult Delete(int Id)
        {
            var product = _prdrepo.GetById(Id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            var product = _prdrepo.GetById(Id);
            _prdrepo.Delete(Id);
            _prdrepo.Save();
            return RedirectToAction("Index");
        }

    }
}