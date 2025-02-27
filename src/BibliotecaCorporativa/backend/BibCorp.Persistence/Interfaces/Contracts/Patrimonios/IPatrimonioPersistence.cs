using BibCorp.Domain.Models.Patrimonios;
using BibCorp.Persistence.Interfaces.Contracts.Shared;

namespace BibCorp.Persistence.Interfaces.Contracts.Patrimonios
{
    public interface IPatrimonioPersistence : ISharedPersistence
    {
        Task<IEnumerable<Patrimonio>> GetAllPatrimoniosAsync();
        Task<Patrimonio> GetPatrimonioByIdAsync(int patrimonioId);
        Task<IEnumerable<Patrimonio>> GetPatrimonioByISBNAsync(string ISBN);
    }
}
