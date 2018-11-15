using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;
using Ext.Net.MVC.Examples.Models;
using System;

namespace Ext.Net.MVC.Examples.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            ExtNetModel model = new ExtNetModel()
            {
                Title = "Welcome to Ext.NET",
                TextAreaEmptyText = ">> Enter a Message Here <<"
            };

            return this.View(model);
        }

        public ActionResult SampleAction(string message)
        {
            X.Msg.Notify(new NotificationConfig
            {
                Icon = Icon.Accept,
                Title = "Working",
                Html = message
            }).Show();

            return this.Direct();
        }
        public ActionResult Test()
        {
            
            return View(Kisiler.getData());
        }
        public ActionResult Cagir(string Item)
        {

            X.Msg.Alert("DirectEvent", string.Format("Item - {0}", Item)).Show();


            return this.Direct();
        }

        public ActionResult Button_Click()
        {
          //  X.Msg.Alert("DirectEvent", string.Format("Item - {0}", Item)).Show();
            return Content("ali");
        }
        public ActionResult UpdateTimeStamp()
        {
            X.Msg.Notify("The Server Time is: ", DateTime.Now.ToLongTimeString()).Show();
            return this.Direct();
        }

    }
}