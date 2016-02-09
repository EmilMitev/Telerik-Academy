namespace StudentSystem.Services.Data
{
    using System.Linq;
    using StudentSystem.Models;

    public interface IStudentsService
    {
        IQueryable<Student> All(int page = 1, int pageSize = 10);

        IQueryable<Student> ById(int id);

        int Add(string firstname, string lastName, int level);

        int Update(int id, string firstname, string lastName, int level);

        int Delete(int id);
    }
}