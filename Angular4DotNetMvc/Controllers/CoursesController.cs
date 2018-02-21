using Angular4DotNetMvc.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseViewModels());
        }

        public string GetSerializedCourseViewModels()
        {
            var courses = new[]
            {
                new CourseViewModel {Number = "CRE202", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseViewModel {Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseViewModel {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }
    }
}