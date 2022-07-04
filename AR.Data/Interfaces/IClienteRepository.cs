using AR.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace AR.Data.Interfaces
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();
        Task add(Cliente entity);
    }
}
