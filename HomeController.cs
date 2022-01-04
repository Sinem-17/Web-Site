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
    public class HomeController : Controller
    {
        MSSQLRepo<Category> repoCategory;
        MSSQLRepo<Product> repoProduct;
        MSSQLRepo<Presentation> repoPresentation;
        MSSQLRepo<SiteInformation> repoSiteInformation;
        public HomeController(MSSQLRepo<Category> _repoCategory, MSSQLRepo<Product> _repoProduct, MSSQLRepo<Presentation> _repoPresentation, MSSQLRepo<SiteInformation> _repoSiteInformation)
        {
            repoCategory = _repoCategory;
            repoProduct = _repoProduct;
            repoPresentation = _repoPresentation;
            repoSiteInformation = _repoSiteInformation;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Categories = repoCategory.GetAll().Include(i => i.Products).OrderBy(o => o.DisplayIndex);
            homeVM.RecentProducts = repoProduct.GetAll().Include(i => i.Pictures).OrderByDescending(o => o.RecDate).Take(6).OrderBy(o => Guid.NewGuid());
            homeVM.Presentations = repoPresentation.GetAll().OrderBy(o => o.DisplayIndex);
            homeVM.Meta = repoSiteInformation.GetBy(x => x.ESiteInfo == ESiteInfo.Meta);
            return View(homeVM);
        }

        [Route("/hata/{code}")]
        public IActionResult ErrorPage(string code)
        {
            ViewBag.Code = code;
            return View();
        }

    }
}
