namespace StudentSystem.Services.Data
{
    using Models;
    using System.Linq;
    using StudentSystem.Data.Repositories;
    using System;

    public class StudentsService : IStudentsService
    {
        private readonly IGenericRepository<Student> students;

        public StudentsService(IGenericRepository<Student> studentsRepo)
        {
            this.students = studentsRepo;
        }

        // public StudentsService()
        // {
        //    var db = new StudentSystemDbContext();
        //    this.students = new GenericRepository<Student>(db);
        // }

        public int Add(string firstname, string lastName, int level)
        {
            var newStudent = new Student
            {
                FirstName = firstname,
                LastName = lastName,
                Level = level
            };

            this.students.Add(newStudent);
            this.students.SaveChanges();

            return newStudent.StudentIdentification;
        }

        public IQueryable<Student> All(int page = 1, int pageSize = 10)
        {
            return this.students
                .All()
                .OrderBy(s => s.StudentIdentification)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Student> ById(int id)
        {
            return this.students
              .All()
              .Where(s => s.StudentIdentification == id);
        }

        public int Delete(int id)
        {
            var studentToDelete = this.students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (studentToDelete == null)
            {
                return 0;
            }

            this.students.Delete(studentToDelete);
            this.students.SaveChanges();

            return studentToDelete.StudentIdentification;
        }

        public int Update(int id, string firstname, string lastName, int level)
        {
            var studentToUpdate = this.students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (studentToUpdate == null)
            {
                return 0;
            }

            studentToUpdate.FirstName = firstname;
            studentToUpdate.LastName = lastName;
            studentToUpdate.Level = level;

            this.students.Update(studentToUpdate);
            this.students.SaveChanges();

            return studentToUpdate.StudentIdentification;
        }
    }
}
