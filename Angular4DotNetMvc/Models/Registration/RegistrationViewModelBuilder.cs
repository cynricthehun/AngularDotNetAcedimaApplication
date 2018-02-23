using Angular4DotNetMvc.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMvc.Models.Registration
{
    public class RegistrationViewModelBuilder
    {
        public RegistrationViewModel BuildRegistrationViewModel()
        {
            var registrationVm = new RegistrationViewModel
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };
            return registrationVm;
        }
        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseViewModel {Number = "CRE202", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseViewModel {Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseViewModel {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializeCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializeCourses;
        }
        public string GetSerializedInstructors()
        {
            var instructors = new[]
            {
                new InstructorsViewModel {Name = "Rubeus Hagrid", Email = "Hagrid@hogwarts.com", RoomNumber = 1001},
                new InstructorsViewModel {Name = "Severus Snape", Email = "Snape@hogwarts.com", RoomNumber = 105},
                new InstructorsViewModel {Name = "Minerva McGonagall", Email = "Mcgonagall@hogwarts.com", RoomNumber = 102}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serializedInstructors;
        }
    }
}