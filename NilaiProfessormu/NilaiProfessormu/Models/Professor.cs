namespace NilaiProfessormu.Models
{
    public class Professor 
    {
        public int Id { get; set; }
        public int BirthDate { get; set; }
        public string Name { get; set; }
        public string School{ get; set; }
        public string Department { get; set; }
        public Country Country { get; set; }
        public ICollection<Review> Reviews {get; set;}
    }
}