namespace EnderunYetimEvi.Models
{
    public static class Repository
    {

        private static List<Donater> donaters = new();
        public static IEnumerable<Donater> donaters_ => donaters;
        
        private static List<Student> students = new();

        public static IEnumerable<Student> students_ => students;
        public static void  Add(Donater donater)
        {
            donaters.Add(donater);
        }

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
