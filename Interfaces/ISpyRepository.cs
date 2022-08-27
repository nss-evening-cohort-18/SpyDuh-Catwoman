using SpyDuhCatWoman.Models;
    
    namespace SpyDuhCatWoman.Interfaces
{
    public interface ISpyRepository
    {
        List<Spy> GetAll();
        bool CreateSpy(Spy spy);
        void PostService(Service service, int id);
    }
}
