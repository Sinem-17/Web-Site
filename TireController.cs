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
    public class TireController : Controller
    {
        MSSQLRepo<Product> repoProduct;
        MSSQLRepo<Category> repoCategory;
        public TireController(MSSQLRepo<Product> _repoProduct, MSSQLRepo<Category> _repoCategory)
        {
            repoProduct = _repoProduct;
            repoCategory = _repoCategory;
        }
        public IActionResult Index()
        {
            ProductVM productVM = new ProductVM();
            productVM.Products = repoProduct.GetAll().Include(i => i.Pictures).Include(i => i.Category).Skip(3);
            return View(productVM);
        }
    }
}
