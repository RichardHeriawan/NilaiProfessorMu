namespace NilaiProfessormu.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public ICollection<Professor> Professors { get; set; }
    }
}