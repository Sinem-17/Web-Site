using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairService.BL.Repositories;
using RepairService.DAL.Entities;
using RepairService.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairService.WebUI.Controllers
{
    public class BodyworkController : Controller
    {
        MSSQLRepo<Product> repoProduct;
        public BodyworkController( MSSQLRepo<Product> _repoProduct)
        {
            repoProduct = _repoProduct;
        }
        public IActionResult Index()
        {
            ProductVM productVM = new ProductVM();
            productVM.Products = repoProduct.GetAll().Include(i => i.Pictures).Include(i => i.Category);
            return View(productVM);
        }
    }
}
