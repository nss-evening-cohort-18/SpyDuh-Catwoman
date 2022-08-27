using SpyDuhCatWoman.Interfaces;

namespace SpyDuhCatWoman.Models
{
    public class Spy
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Services  { get; set; }
        public List<int> Friends { get; set; } = new();
        public List<int> Enemies { get; set; } = new();
    }
}
