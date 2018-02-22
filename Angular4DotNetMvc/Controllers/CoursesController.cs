using Angular4DotNetMvc.Models;
using Angular4DotNetMvc.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : Controller
    {
        private RegistrationViewModelBuilder _registrationVmBuilder = new RegistrationViewModelBuilder();
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedCourses());
        }
    }
}