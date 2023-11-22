
namespace EnderunYetimEvi.Models
{
    public class Donater
    {
        public String? Email { get; set; }=String.Empty;
        public String? Name { get; set; }=String.Empty;
        public String? LastName { get; set; }=String.Empty;
        public String? FullName => $"{Name} {LastName?.ToUpper()}";
        public int TC { get; set; }
        public int Price { get; set; }
        public String? SelectedState {  get; set; }=String.Empty;  
        public DateTime ApplyAt { get; set; }

        public Donater() 
        {
            ApplyAt=DateTime.Now; 
        }
    }





}

   