namespace NilaiProfessormu.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public int Text { get; set; }
        public Professor Professor { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}