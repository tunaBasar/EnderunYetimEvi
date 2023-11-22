namespace EnderunYetimEvi.Models
{
    public class Student
    {
        public String? Name { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{Name} {LastName?.ToUpper()}";
        public int TC { get; set; }
        public int Age { get; set; }
    }
}
