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
                },
                Services = new List<string>()
            },
            new Spy()
            {
                Id = 2,
                Alias = "Tommy",
                Skills = new List<string>()
                {
                    "Sneaking",
                    "Hacking",
                },
                Services = new List<string>()
            },
            new Spy()
            {
                Id = 3,
                Alias = "Robert",
                Skills = new List<string>()
                {
                    "Sneaking",
                    "Pickpocketing"
                },
                Services = new List<string>()
            }
        };

        public bool CreateSpy(Spy value)
        {
            _spyData.Add(value);
            return true;
        }
        public List<Spy> GetAll()
        {
            return _spyData;
        }

        public Spy GetById(int id)
        {
            return _spyData.FirstOrDefault(s => s.Id == id);
        }

        public List<Spy> GetBySkill(string skill)
        {
            return _spyData.Where(p => p.Skills.Contains(skill)).ToList();
        }

        public void PostService(string value, int spyId)
        {
            Spy SpyMatch = _spyData.Find((x) => x.Id == spyId);
            SpyMatch.Services.Add(value);
        }
        public void PostSkill(string value, int spyId)
        {
            Spy SpyMatch = _spyData.Find((x) => x.Id == spyId);
            SpyMatch.Skills.Add(value);
        }

    }
}

