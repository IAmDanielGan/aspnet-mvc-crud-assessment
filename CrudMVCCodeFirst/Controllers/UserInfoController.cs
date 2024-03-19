using CrudMVCCodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVCCodeFirst.Controllers
{
    public class UserInfoController : Controller
    {

        private readonly UserInfoContext userContext = new UserInfoContext();
        // GET: UserInfo
        public ActionResult Index()
        {            
            return View(userContext.UserInfo.ToList());
        }
    }
}