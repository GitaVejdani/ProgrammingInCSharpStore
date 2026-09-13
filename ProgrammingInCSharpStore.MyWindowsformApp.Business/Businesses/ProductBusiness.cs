using ProgrammingInCSharpStore.Business.Interfaces;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

namespace ProgrammingInCSharpStore.Business.Businesses
{
    public class ProductBusiness : IProductBusiness
    {

        string connectionString = "Data Source=localhost;Initial Catalog=ProgrammingInCSharpStoreDB;Integrated Security=True;";

        public bool Add(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
