using EcommerceMVC.Models;
using EcommerceMVC.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class ProductsController : Controller    //to make CRUD operations
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var Products = context.Products.OrderByDescending(P => P.Id).ToList();
            return View(Products);
        }

        public IActionResult Create()
        {
           
            return View();
        }

    }
}





