/* Problem 9.
    * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    * Create a List<Student> with sample students. Select only the students that are from group number 2.
    * Use LINQ query. Order the students by FirstName.
 */
// Solutions for promlem from 9 to 19, without problem 17 :)
namespace _09.StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Vasil", "Ivanov", "12306", "0899000000", "vasIvanov@gmail.com", new List<int> { 5, 4, 3, 4, 5, 4, 3 }, 2),
                new Student("Pesho", "Shapkov", "23456", "0899000001", "peshShapkov@abv.bg", new List<int> { 2, 3, 4, 5, 5, 4, 3 }, 3),
                new Student("Stamat", "Kolev", "34562", "0899000002", "stKolev@gmail.com", new List<int> { 6, 4, 4, 4, 5, 6, 6 }, 1),
                new Student("Qvor", "Georgiev", "10023", "02343535", "QvGeorgiev@gmail.com", new List<int> { 4, 6, 3, 2, 4, 6, 2 }, 2),
                new Student("Dragan", "Cankov", "54306", "0899000004", "DrCankov@abv.bg", new List<int> { 5, 6, 5, 5, 5, 4, 5 }, 3),
            };

            // Problem 10
            Console.WriteLine("Student from group 2 (using extension methods) :");
            Console.WriteLine(new string('*', 79));

            var studentFromGroupTwo = listOfStudents
                                        .Where(x => x.GroupNumber == 2)
                                        .Select(x => x)
                                        .OrderBy(x => x.FirstName);

            foreach (var item in studentFromGroupTwo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 9
            Console.WriteLine("Student from group 2 (using LINQ) :");
            Console.WriteLine(new string('*', 79));

            var studentGroupTwo =
                from st in listOfStudents
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var item in studentGroupTwo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problemn 11
            Console.WriteLine("Student with email from abv.bg :");
            Console.WriteLine(new string('*', 79));

            var studentEmail =
                from st in listOfStudents
                where st.Email.Substring(st.Email.IndexOf("@") + 1) == "abv.bg"
                select st;

            foreach (var item in studentEmail)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 12
            Console.WriteLine("Students with telephone in Sofia:");
            Console.WriteLine(new string('*', 79));

            var studentTelephone =
                from st in listOfStudents
                where st.Tel.StartsWith("02")
                select st;

            foreach (var item in studentTelephone)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 13
            Console.WriteLine("Students with at least one mark 6 : ");
            Console.WriteLine(new string('*', 79));

            var exellentMarks =
                from st in listOfStudents
                where st.Marks.Contains(6)
                select st;

            foreach (var item in exellentMarks)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 14
            Console.WriteLine("Students with two poor marks: ");
            Console.WriteLine(new string('*', 79));

            var poorMarks = listOfStudents
                .Where(st => st.Marks.Count(x => x == 2) == 2);

            foreach (var item in poorMarks)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 15
            Console.WriteLine("Students from 2006 marks: ");
            Console.WriteLine(new string('*', 79));

            var studentMarks = listOfStudents
                                .Where(st => st.FN[3] == '0' && st.FN[4] == '6');

            foreach (var item in studentMarks)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(string.Join(" ", item.Marks));
            }

            Console.WriteLine(new string('*', 79));

            // Problem 18
            Console.WriteLine("Students ordered by group number: ");
            Console.WriteLine(new string('*', 79));

            var groupStudent =
                from st in listOfStudents
                orderby st.GroupNumber
                select st;

            foreach (var item in groupStudent)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));

            // Problem 19
            Console.WriteLine("Students ordered by group number(using extention methods): ");
            Console.WriteLine(new string('*', 79));

            var groupStudentsLambda = listOfStudents
                .OrderBy(x => x.GroupNumber);

            foreach (var item in groupStudent)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 79));
        }
    }
}