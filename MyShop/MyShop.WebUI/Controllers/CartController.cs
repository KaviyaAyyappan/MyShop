using Microsoft.Ajax.Utilities;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MyShop.WebUI.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add(string Id)
        {
            Product product = new Product();
            if(Session["cart"]== null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { product = product.Find(Id), Quantity = 1 });
            }
           
            }
            return RedirectToAction("Index");
        }
        }
    }
}