namespace StudentSystem.Services.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Web.Models;
    using System.Web.Http;
    using AutoMapper;
    using StudentSystem.Models;
    using System.Linq;

    public class CoursesController : ApiController
    {
        private IStudentSystemData data;

        public CoursesController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Courses.All().ProjectTo<CourseModel>());
        }

        public IHttpActionResult Post([FromBody] CourseModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var result = Mapper.Map<Course>(model);

                this.data.Courses.Add(result);

                return this.Created(this.Url.ToString(), result);
            }
        }

        public IHttpActionResult Put([FromBody] CourseModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var course = this.data.Courses.SearchFor(x => x.Name == model.Name).FirstOrDefault();

                if (course == null)
                {
                    return this.NotFound();
                }
                else
                {
                    course.Description = model.Description;

                    this.data.Courses.Update(course);
                    return this.Ok(course);
                }
            }
        }

        public IHttpActionResult Delete([FromBody] string guid)
        {
            var course = this.data.Courses.SearchFor(x => x.Id.ToString() == guid).FirstOrDefault();

            if (course == null)
            {
                return this.NotFound();
            }
            else
            {
                this.data.Courses.Delete(course);
                return this.Ok(course);
            }
        }
    }
}
