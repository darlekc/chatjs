using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatJsSample.Controllers
{
    public class CheckoutController : Controller
    {
        public string Cancelled()
        {
            return "You cancelled";
        }

        public string Thanks()
        {
            return "Thanks!";
        }
    }
}
