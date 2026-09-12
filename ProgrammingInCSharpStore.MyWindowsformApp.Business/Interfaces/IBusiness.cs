namespace ProgrammingInCSharpStore.Business.Interfaces;

public interface IBusiness <T> where T : class
{
    bool Add(T item);

    bool Delete(T item);

    bool Update(T item);

    T GetById(int id);

     List<T> GetAll(int pageNo, int pageSize);

}
