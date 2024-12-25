using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Presenters.interfaces
{
    public interface IClientPresenter
    {
        void AddClient(ClientDTO client);
        void DeleteClient(ClientDTO client);
        void UpdateClient(ClientDTO client);
        IEnumerable<ClientDTO> GetClients();
        void GetClientById(long id);
        void GetPhoto(ClientDTO client);
    }
}
