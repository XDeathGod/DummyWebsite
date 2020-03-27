using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.Data;
using DummyWebsite;
using Sitecore.Data.Items;

namespace DummyWebsite.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult GetServices()
        {
            Database currentDb = Sitecore.Context.Database;

            string datasource = RenderingContext.Current.Rendering.DataSource;

            Item item = currentDb.GetItem(datasource);

            List<Item> itemServices = item.GetChildren().ToList();

            return View("/Views/ServicesSection.cshtml", itemServices);
        }
    }
}