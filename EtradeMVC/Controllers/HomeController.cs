using ETrade.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Etrade.Business.Abstract;
using ETrade.Entities.Concrete;
using EtradeMVC.Filters;
using EtradeMVC.Models;

namespace EtradeMVC.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public HomeController()
        {
            
        }

        // GET: Home
        public ActionResult Add()
        {
            return View(new ProductAddView());
        }

        [HttpPost]
       [ExceptionHandlerAttribute]
        public ActionResult Add(Productcs productcs)
        {
            _productService.Add(productcs);

            return View(new ProductAddView());
        }
    }
}