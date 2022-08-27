using SpyDuhCatWoman.Interfaces;
using SpyDuhCatWoman.Models;

namespace SpyDuhCatWoman.Repositories
{
    public class SpyRepository : ISpyRepository
    {
        private static List<Spy> _spyData = new()
        {
            new Spy()
            {
                Id = 1,
                Alias = "John",
                Skills = new List<string>()
                {
                    "Hacking",
                    "Pickpocketing"
                }
            },
            new Spy()
            {
                Id = 2,
                Alias = "Tommy",
                Skills = new List<string>()
                {
                    "Sneaking",
                    "Hacking",
                }
            },
            new Spy()
            {
                Id = 3,
                Alias = "Robert",
                Skills = new List<string>()
                {
                    "Sneaking",
                    "Pickpocketing"
                }
            }
        };

    public class SpyRepository
    {
        private static List<Spy> _spyData = new();
        public bool CreateSpy(Spy value)
        {
            _spyData.Add(value);
            return true;
        }
        public List<Spy> GetAll()
        {
            return _spyData;
        }
        public void PostService(Service value, int spyId)
        {
            Spy SpyMatch = _spyData.Find((x) => x.Id == spyId);
            SpyMatch.Attributes.Add(value);
        }
    }
}
