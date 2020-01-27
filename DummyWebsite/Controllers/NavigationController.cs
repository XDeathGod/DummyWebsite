using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyWebsite.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult HeaderNav()
        {
            //Get the current db
            Database currentdb = Sitecore.Context.Database;
            //Get the datasurce
            string datasourcepath = RenderingContext.Current.Rendering.DataSource;

            Item datasource = currentdb.GetItem(datasourcepath);

            //Get the list of Navigation item from the datasource

            List<Item> navigationItems = datasource.GetChildren().ToList();

            //pass the list of items as a model to the views
            return View("/Views/Navigation.cshtml", navigationItems);

        }

        public ActionResult FooterNav()
        {
            Database currentdb = Sitecore.Context.Database;

            string datasourcePath = RenderingContext.Current.Rendering.DataSource;

            Item dataSource = currentdb.GetItem(datasourcePath);

            List<Item> navItem = dataSource.GetChildren().ToList();

            return View("/Views/Footer Navigation.cshtml", navItem);
        }
    }
}