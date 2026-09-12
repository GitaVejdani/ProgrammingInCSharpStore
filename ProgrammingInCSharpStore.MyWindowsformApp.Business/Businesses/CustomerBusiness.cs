using ProgrammingInCSharpStore.Business.Interfaces;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

namespace ProgrammingInCSharpStore.Business.Businesses;

public class CustomerBusiness : ICustomerBusiness
{
    string connectionString = "Data Source=localhost;Initial Catalog=ProgrammingInCSharpStoreDB;Integrated Security=True;";

    public bool Add(Customer item)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Customer item)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll(int pageNo, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Customer GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Customer item)
    {
        throw new NotImplementedException();
    }
}
