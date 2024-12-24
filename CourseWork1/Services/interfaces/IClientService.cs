using System.Collections.Generic;

namespace CourseWork1.Services
{
    public interface IClientService
    {
        void RegisterClient(IClient client);
        bool DeleteClient(IClient client);
        void EditClient(IClient client);
        IClient GetClientById(long id);
        IEnumerable<IClient> GetAllClients();
    }
}
