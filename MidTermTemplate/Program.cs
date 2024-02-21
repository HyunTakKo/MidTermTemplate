
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = Course.GetDictionary();

            Console.WriteLine("List all the courses from the dictionary");
            foreach (var course in courses)
            {
                Console.WriteLine(course.Value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();


            // Add a new Course to the dictionary
            Course newCourse = new Course("COMP500", "Advanced Computer Science", "COMP100 COMP213", true, 3);
            if (courses.ContainsKey(newCourse.Code))
            {
                Console.WriteLine("Error: Duplicate course.");
            }
            else
            {
                courses.Add(newCourse.Code, newCourse);
                Console.WriteLine("Added new course: " + newCourse.ToString());
            }

            // List all the courses from the dictionary
            foreach (var course in courses)
            {
                Console.WriteLine(course.Value.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            // Try adding the same course again:
            if (courses.ContainsKey(newCourse.Code))
            {
                Console.WriteLine("Error: Duplicate course.");
            }
            else
            {
                courses.Add(newCourse.Code, newCourse);
                Console.WriteLine("Added new course: " + newCourse.ToString());
            }


            // List all the courses from the dictionary
            foreach (var course in courses)
            {
                Console.WriteLine(course.Value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();

            // Remove a course from the dictionary
            string courseCodeToRemove = "COMP500";
            if (courses.ContainsKey(courseCodeToRemove))
            {
                courses.Remove(courseCodeToRemove);
                Console.WriteLine("Removed course with code: " + courseCodeToRemove);
            }
            else
            {
                Console.WriteLine("Course code not found.");
            }

            // List all the courses from the dictionary
            foreach (var course in courses)
            {
                Console.WriteLine(course.Value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();

            // Find a course by name
            string courseName1 = "Programming 2"; // This course should exist in the dictionary
            Course foundCourse1 = courses.Values.FirstOrDefault(c => c.Name == courseName1);
            if (foundCourse1 != null)
            {
                Console.WriteLine("Found course: " + foundCourse1.ToString());
            }
            else
            {
                Console.WriteLine("Course name not found.");
            }

            string courseName2 = "Advanced Computer Science"; // This course should not exist in the dictionary
            Course foundCourse2 = courses.Values.FirstOrDefault(c => c.Name == courseName2);
            if (foundCourse2 != null)
            {
                Console.WriteLine("Found course: " + foundCourse2.ToString());
            }
            else
            {
                Console.WriteLine("Course name not found.");
            }


            Console.WriteLine();
            Console.WriteLine();

            // List all courses with specific PreReq
            var specificPreReqCourses = courses.Values.Where(c => c.PreReq == "COMP123 COMP125" || c.PreReq == "COMP123 COMP301" || c.PreReq == "COMP247");
            Console.WriteLine("Courses with specific prerequisites:");
            foreach (var course in specificPreReqCourses)
            {
                Console.WriteLine(course.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            // List all elective courses
            var electiveCourses = courses.Values.Where(c => !c.Core);
            Console.WriteLine("Elective courses:");
            foreach (var course in electiveCourses)
            {
                Console.WriteLine(course.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            // List all courses, sorted by Course Code
            var sortedCourses = courses.Values.OrderBy(c => c.Code);
            Console.WriteLine("Courses sorted by code:");
            foreach (var course in sortedCourses)
            {
                Console.WriteLine(course.ToString());
            }
        }
    }
}