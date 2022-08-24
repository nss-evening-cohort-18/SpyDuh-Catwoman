using SpyDuhCatWoman.Models;

namespace SpyDuhCatWoman.Repositories
{
    public class SpyRepository
    {
        private static List<Spy> _spyData = new();

        public void CreateSpy(Spy newSpy)
        {
            _spyData.Add(newSpy);
        }

        public List<Spy> GetAll()
        {
            return _spyData;
        }
    }
}
