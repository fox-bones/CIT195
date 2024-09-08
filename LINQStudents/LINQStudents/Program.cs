﻿namespace LINQStudents
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double Tuition { get; set; }
    }
    public class StudentClubs
    {
        public int StudentID { get; set; }
        public string ClubName { get; set; }
    }
    public class StudentGPA
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 5, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 6, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 7, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
            };
            // Student GPA Collection
            IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
                };
            // Club collection
            IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
            };
            var gpaList = studentGPAList.OrderBy(x => x.GPA).Select(x => x.StudentID).ToList();
            foreach (var student in gpaList)
                Console.WriteLine(student);
            Console.WriteLine();
            var clubList = studentClubList.OrderBy(x => x.ClubName).GroupBy(x => x.ClubName).ToList();
            foreach (var student in studentClubList)
                Console.WriteLine(student.StudentID);
            Console.WriteLine();
            var passingGPAs = studentGPAList.Where(x => x.GPA >= 2.5 &&  x.GPA <= 4.0).ToList();
            Console.WriteLine(passingGPAs.Count());
            Console.WriteLine();
            var averageTuition = studentList.Select(x => x.Tuition).Average();
            Console.WriteLine(averageTuition);
            Console.WriteLine();
            var highestTuition = studentList.Max(x => x.Tuition);
            foreach (var student in studentList)
            {
                if (student.Tuition == highestTuition)
                {
                    Console.WriteLine(student.StudentName);
                    Console.WriteLine(student.Major);
                    Console.WriteLine(student.Tuition);
                }
            }
            Console.WriteLine();
            var gpaStudentList = studentList.Join(studentGPAList, gpa => gpa.StudentID, student => student.StudentID,
                                                    (student, gpa) => new
                                                    {
                                                        studentName = student.StudentName,
                                                        studentMajor = student.Major,
                                                        gpa = gpa.GPA
                                                    }).ToList();
            foreach (var student in gpaStudentList)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            var clubStudentList = studentList.Join(studentClubList, club => club.StudentID, student => student.StudentID,
                (student, club) => new
                {
                    studentID = student.StudentID,
                    studentName = student.StudentName,
                    clubName = club.ClubName
                }).Where(x => x.clubName == "Game").ToList();
            foreach (var student in clubStudentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
