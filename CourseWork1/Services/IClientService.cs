using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Services
{
    public interface IClientService
    {
        void RegisterClient(IClient client);
        void DeleteClient(IClient client);
        void EditClient(IClient client);
        IClient GetClientById(int id);
        IEnumerable<IClient> GetAllClients();
    }
}
