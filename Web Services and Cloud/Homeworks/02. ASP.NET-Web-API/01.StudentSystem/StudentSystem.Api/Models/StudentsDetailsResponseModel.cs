namespace StudentSystem.Api.Models
{
    using StudentSystem.Models;
    using System;
    using System.Linq.Expressions;

    public class StudentsDetailsResponseModel
    {
        public static Expression<Func<Student, StudentsDetailsResponseModel>> FromModel
        {
            get
            {
                return s => new StudentsDetailsResponseModel
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Level = s.Level
                };
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Level { get; set; }
    }
}
