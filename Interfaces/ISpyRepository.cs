using SpyDuhCatWoman.Models;
    
    namespace SpyDuhCatWoman.Interfaces
{
    public interface ISpyRepository
    {
        List<Spy> GetAll();
        bool CreateSpy(Spy spy);
        bool CreateEnemy(Spy newEnemy);
        Spy GetById(int id);
        List<Spy> GetBySkill(string skill);


        List<Spy> GetByEnemy(int enemy);

        void PostService(string service, int id);
        void PostSkill(string skill, int id);

    }
}
