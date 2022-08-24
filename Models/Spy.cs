namespace SpyDuhCatWoman.Models
{
    public class Spy
    {
        int Id { get; set; }
        string Alias { get; set; }
        List<string> Skills { get; set; } = new();
        List<string> Services { get; set; } = new();
        List<int> Friends { get; set; } = new();
        List<int> Enemies { get; set; } = new();
    }
}
