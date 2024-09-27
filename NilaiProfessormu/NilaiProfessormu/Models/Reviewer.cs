namespace NilaiProfessormu.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public ICollection<Review> Reviews {get; set;}
    }
}