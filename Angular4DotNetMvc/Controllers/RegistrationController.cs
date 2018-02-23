using Angular4DotNetMvc.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationViewModelBuilder _registrationViewModelBuilder = new RegistrationViewModelBuilder();

        public ActionResult Index()
        {
            return View(_registrationViewModelBuilder.BuildRegistrationViewModel());
        }
    }
}