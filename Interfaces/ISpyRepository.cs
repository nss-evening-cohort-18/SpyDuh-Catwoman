using SpyDuhCatWoman.Models;
    
    namespace SpyDuhCatWoman.Interfaces
{
    public interface ISpyRepository
    {
        List<Spy> GetAll();
        bool CreateSpy(Spy spy);
        Spy GetById(int id);
        List<Spy> GetBySkill(string skill);

        void PostService(Service service, int id);
    }
}
