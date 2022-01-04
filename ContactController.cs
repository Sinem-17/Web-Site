using Microsoft.AspNetCore.Mvc;
using RepairService.BL.Repositories;
using RepairService.DAL.Entities;
using RepairService.Tools;
using RepairService.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairService.WebUI.Controllers
{
    public class ContactController : Controller
    {
        MSSQLRepo<SiteInformation> repoSiteInformation;
        MSSQLRepo<ContactForm> repoContantForm;
        public ContactController(MSSQLRepo<ContactForm> _repoContantForm, MSSQLRepo<SiteInformation> _repoSiteInformation)
        {
            repoSiteInformation = _repoSiteInformation;
            repoContantForm = _repoContantForm;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Contact = repoSiteInformation.GetBy(g => g.ESiteInfo == ESiteInfo.Contact),
                Social = repoSiteInformation.GetBy(g => g.ESiteInfo == ESiteInfo.Social)
            };
            return View(contactVM);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Index(ContactVM model)
        {
            model.ContactForm.RecDate = DateTime.Now;
            model.ContactForm.IPNO = HttpContext.Connection.RemoteIpAddress.ToString();
            repoContantForm.Add(model.ContactForm);

            return RedirectToAction("Index");
        }
    }
}
