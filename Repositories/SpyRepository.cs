using SpyDuhCatWoman.Models;

namespace SpyDuhCatWoman.Repositories
{
    public class SpyRepository
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

        public bool CreateSpy(Spy value)
        {
            _spyData.Add(value);
            return true;
        }

        public Spy GetById(int id)
        {
            return _spyData.FirstOrDefault(s => s.Id == id);
        }

        public List<Spy> GetBySkill(string skill)
        {
            return _spyData.Where(p => p.Skills.Contains(skill)).ToList();
        }

        public List<Spy> GetAll()
        {
            return _spyData;
        }
    }
}
