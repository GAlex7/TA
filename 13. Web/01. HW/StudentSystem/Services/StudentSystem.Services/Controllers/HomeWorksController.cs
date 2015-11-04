namespace StudentSystem.Services.Controllers
{
    using Data;
    using Models;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;


    public class HomeWorksController : ApiController
    {
        private IStudentSystemData data;

        public HomeWorksController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Homeworks.All().ProjectTo<HomeworkModel>());
        }
    }
}
