using System.Collections.Generic;

namespace Question1
{
    public class Course : IComparable<string>
    {
        public string Code { get; }
        public string Name { get; }
        public string PreReq { get; }
        public bool Core { get; }
        public int Semester { get; }
        public Course(string code, string name, string prereq, bool core, int semester)
        {
            Code = code; Name = name;
            PreReq = prereq; Core = core;
            Semester = semester;
        }
        public override string ToString()
            => $"{Code}({Semester}) - {Name} ({(Core ? "Core" : "Elective")})";
        public static Dictionary<string, Course> GetDictionary()
            => new Dictionary<string, Course> 
            {
                {"COMP100", new Course("COMP100", "Programming 1", "", true, 1)},
                {"COMP120", new Course("COMP120", "Software Engineering Fundamentals", "", true, 1)},
                {"COMP213", new Course("COMP213", "Web Interface Design", "", true, 1)},
                {"MATH175", new Course("MATH175", "Functions and Number Systems", "", true, 1)},
                {"COMP123", new Course("COMP123", "Programming 2", "COMP100", true, 2)},
                {"COMM160", new Course("COMM160", "College Communication 1", "", true, 1)},
                {"MATH210", new Course("MATH210", "Linear Algebra and Statistics", "MATH175 MATH185", true, 3)},
                {"COMP125", new Course("COMP125", "Client-Side Web Development", "COMP100 COMP213", true, 2)},
                {"COMP301", new Course("COMP301", "UNIX/Linux Operating Systems", "COMP100", true, 2)},
                {"GEND500", new Course("GEND500", "General Elective Education", "", false, 4)},
                {"COMM170", new Course("COMM170", "College Communication 2", "COMM160", true, 2)},
                {"COMP229", new Course("COMP229", "Web Application Development", "COMP123 COMP125", true, 3)},
                {"COMP216", new Course("COMP216", "Networking For Software Developers", "COMP123 COMP301", true, 6)},
                {"COMP212", new Course("COMP212", "Programming 3", "COMP123", true, 4)},
                {"COMP377", new Course("COMP377", "Programming AI For Software Developers", "COMP123", false, 4)},
                {"COMP397", new Course("COMP397", "Web Game Development", "COMP123", false, 4)},
                {"COMP264", new Course("COMP264", "Cloud Machine Learning", "COMP247", true, 5)},
                {"ENGL253", new Course("ENGL253", "Advanced Business Communication", "COMM170", true, 4)},
            };

        public int CompareTo(string? other)
        {
            if (other == null) return 1;

            return Code.CompareTo(other);
        }
    }
}
