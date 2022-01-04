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
    public class SearchController : Controller
    {
        MSSQLRepo<Category> repoCategory;
        MSSQLRepo<Product> repoProduct;
        public SearchController(MSSQLRepo<Category> _repoCategory, MSSQLRepo<Product> _repoProduct)
        {
            repoCategory = _repoCategory;
            repoProduct = _repoProduct;
        }

        public IActionResult Index(string ara)
        {
            //ProductVM productVM = new ProductVM();
            //productVM.Products = repoProduct.GetAll().Include(i => i.Pictures).Include(i => i.Category);

            return View(repoProduct.GetAll(g=>g.Name.Contains(ara)||g.Description.Contains(ara)||ara==null).Include(i=>i.Pictures));

        }
       
    }
}
