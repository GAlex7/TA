namespace StudentSystem.Services.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Models;
    using System.Web.Http;

    public class TestsController : ApiController
    {
        private IStudentSystemData data;

        public TestsController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Tests.All().ProjectTo<TestModel>());
        }
    }
}
