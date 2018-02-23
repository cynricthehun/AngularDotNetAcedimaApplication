using Angular4DotNetMvc.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class InstructorsController : Controller
    {
        private RegistrationViewModelBuilder _registrationVmBuilder = new RegistrationViewModelBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
        }
    }
}