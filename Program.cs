namespace immutableID
{
    internal class Program
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            public Student(int i)
            {
                Id = i;
                FirstName = "";
                LastName = "";
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student(1);
            student1.FirstName = "John";
            student1.LastName = "White";
            Student student2 = new Student(2, "Laura", "Brown");
            Console.WriteLine($"Student ID: {student1.Id}\nStudent Name: {student1.FirstName} {student1.LastName}\n");
            Console.WriteLine($"Student ID: {student2.Id}\nStudent Name: {student2.FirstName} {student2.LastName}\n");
        }
    }
}
