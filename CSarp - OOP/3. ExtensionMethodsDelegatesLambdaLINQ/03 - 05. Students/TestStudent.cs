/* Problem 3
    * Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    * Use LINQ query operators.
*/
/* Problem 4.
 * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 */
/* Problem 5.
    * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    * Rewrite the same with LINQ.
 */
namespace _03___05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class TestStudent
    {
        private static void Main()
        {
            List<Student> list = new List<Student>
            {
                              new Student("Peter", "Petrov", 21),
                              new Student("Grisko", "Kurshishapkov", 25),
                              new Student("Ivanka", "Stankova", 22),
                              new Student("Qgodka", "Malinkova", 20),
                              new Student("Gosho", "Familnikov", 28)
                                                  };

            var firstBeforeLast =
                from student in list
                where student.Firstname.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("Students whose first name is before last name:");
            Console.WriteLine(new string('*', 50));

            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 50));

            // age between 18 and 24
            var ageRange =
                from st in list
                where st.Age > 18 && st.Age < 24
                select st;

            Console.WriteLine("Student with age between 18 and 24:");
            Console.WriteLine(new string('*', 50));

            foreach (var item in ageRange)
            {
                Console.WriteLine(item.Firstname + " " + item.LastName);
            }

            Console.WriteLine(new string('*', 50));

            // order students
            var orderedStudent =
                from st in list
                orderby st.Firstname descending, st.LastName descending
                select st;

            Console.WriteLine("Ordered students in descending using LINQ :");
            Console.WriteLine(new string('*', 50));

            foreach (var item in orderedStudent)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 50));

            var orderedStudentLambda = list
                .OrderByDescending(st => st.Firstname)
                .ThenByDescending(st => st.LastName)
                .Select(st => st);

            Console.WriteLine("Ordered student using lambda expressions:");
            Console.WriteLine(new string('*', 50));

            foreach (var item in orderedStudentLambda)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 50));
        }
    }
}
