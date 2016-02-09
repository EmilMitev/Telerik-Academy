namespace StudentSystem.Api.Controllers
{
    using Services.Data;
    using System.Web.Http;
    using System.Linq;
    using Models;

    public class StudentsController : ApiController
    {
        private readonly IStudentsService students;

        public StudentsController(IStudentsService studentService)
        {
            this.students = studentService;
        }

        // public StudentsController()
        //    : this(new StudentsService())
        // {
        // }

        public IHttpActionResult Get()
        {
            var result = this.students
                .All()
                .Select(StudentsDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {

            var result = this.students
                .ById(id)
                .Select(StudentsDetailsResponseModel.FromModel)
                .FirstOrDefault();

            return this.Ok(result);
        }

        public IHttpActionResult Post([FromBody]StudentsDetailsResponseModel student)
        {
            if (student == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.students
                .Add(student.FirstName,
                     student.LastName,
                     student.Level);

            return this.Ok(result);
        }

        public IHttpActionResult Delete(int id)
        {
            var result = this.students.Delete(id);

            if (result == 0)
            {
                return this.BadRequest("Student doesnt exist!");
            }

            return this.Ok(string.Format("Student {0} deleted!", result));
        }

        public IHttpActionResult Put(int id, [FromBody] StudentsDetailsResponseModel student)
        {
            if (student == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var result = this.students.Update(id, student.FirstName, student.LastName, student.Level);

            if (result == 0)
            {
                return this.BadRequest("Student doesnt exist!");
            }

            return this.Ok(string.Format("Student {0} updated!", result));
        }
    }
}