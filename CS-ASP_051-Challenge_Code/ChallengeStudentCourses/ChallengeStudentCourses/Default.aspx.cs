using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "I didn't worry too much about making the formatting look pretty";
        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            resultLabel.Text = "";

            List<Course> ExistingCourses = new List<Course>()
            {
                new Course() {CourseId = 1, Name = "TypingCourse", Students = new List<Student>(){
                        new Student() {Name = "Freddo", StudentId = 1},
                        new Student() {Name = "Frodo", StudentId = 2},
                    }
                },

                new Course() {CourseId = 2, Name = "SkydivingCourse", Students = new List<Student>(){
                        new Student() {Name = "Birdo", StudentId = 3},
                        new Student() {Name = "BagelBoy", StudentId = 4},
                    }
                },

                new Course() {CourseId = 3, Name = "HowToDrinkWaterCourse", Students = new List<Student>(){
                        new Student() {Name = "I Don't Know How To Drink Water Jones", StudentId = 5},
                        new Student() {Name = "DryThroat Cathie", StudentId = 6},
                    }
                },
            };

            foreach (Course course in ExistingCourses)
            {
                resultLabel.Text += String.Format("{0}, {1}:, {2} ", course.Name, course.CourseId, "<br />");
                foreach (Student student in course.Students)
                {
                    resultLabel.Text += String.Format("{0}, {1}, {2}", student.Name, student.StudentId, "<br />");
                }
            }

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            resultLabel.Text = "";

            Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>()
            {
                {1, new Student() {Name = "Freddo", StudentId = 1, Courses = new List<Course>{ new Course() {Name = "TypingCourse", CourseId = 1 }, new Course {Name = "SkydivingCourse", CourseId = 2 } } } },
                {2, new Student() {Name = "Frodo", StudentId = 2, Courses = new List<Course>{ new Course() {Name = "TypingCourse", CourseId = 1 }, new Course {Name = "SkydivingCourse", CourseId = 2 } } } },
                {3, new Student() {Name = "Birdo", StudentId = 3, Courses = new List<Course>{ new Course() {Name = "TypingCourse", CourseId = 1 }, new Course {Name = "SkydivingCourse", CourseId = 2 } } } },
            };

            foreach (var student in StudentDictionary)
            {
                resultLabel.Text += String.Format("{0}, {1} -", student.Value.Name, student.Value.StudentId);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += course.CourseId + " " + course.Name + "</ br>";
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            resultLabel.Text = "";

            Student test = new Student();
            test.StudentId = 1;
            test.Name = "Flyaway Sullivan";

            test.Grades = new List<Grade>()
            {
                new Grade{Course = new Course{Name = "EurekaCourse" }, CourseGrade = 90 }
            };

            foreach (var grade in test.Grades)
            {
                resultLabel.Text += "StudentId " + test.StudentId + ": " + "Student name " + test.Name + ": " + grade.Course.Name + " " + grade.CourseGrade;
            }
        }


    }
}