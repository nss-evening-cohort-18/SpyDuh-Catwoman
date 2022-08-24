using SpyDuhCatWoman.Models;

namespace SpyDuhCatWoman.Repositories
{
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
    }
}
