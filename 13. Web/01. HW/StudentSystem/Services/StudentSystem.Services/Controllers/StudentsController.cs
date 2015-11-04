namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private IStudentSystemData data;

        public StudentsController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Students.All().ProjectTo<StudentModel>());
        }

        [HttpGet]
        public IHttpActionResult All(int id)
        {
            var results = this.data.Students.SearchFor(x => x.StudentIdentification == id);

            if (results.Count() == 0)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(results.ProjectTo<StudentModel>());
            }
        }

        public IHttpActionResult Post([FromBody] StudentModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var result = Mapper.Map<Student>(model);

                this.data.Students.Add(result);

                return this.Created(this.Url.ToString(), result);
            }
        }

        public IHttpActionResult Put(int id, [FromBody] StudentModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            else
            {
                var student = this.data.Students.SearchFor(x => x.StudentIdentification == id).FirstOrDefault();

                if (student == null)
                {
                    return this.NotFound();
                }
                else
                {
                    student.FirstName = model.FirstName;
                    student.LastName = model.LastName;

                    this.data.Students.Update(student);
                    return this.Ok(student);
                }
            }
        }

        public IHttpActionResult Delete(int id)
        {
            var student = this.data.Students.SearchFor(x => x.StudentIdentification == id).FirstOrDefault();

            if (student == null)
            {
                return this.NotFound();
            }
            else
            {
                this.data.Students.Delete(student);
                return this.Ok(student);
            }
        }
    }
}
