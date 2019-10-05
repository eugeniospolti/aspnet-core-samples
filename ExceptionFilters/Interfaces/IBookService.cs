using ExceptionFilters.Controllers;

namespace ExceptionFilters.Interfaces
{
    public interface IBookService
    {
        Book Get(int id);
    }
}