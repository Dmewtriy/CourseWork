using CourseWork1.DTOs;
using System;
using System.Collections.Generic;

namespace CourseWork1.Views
{
    public interface IClientView
    {
        event EventHandler<ClientDTO> ClientAdded;
        event EventHandler<ClientDTO> ClientUpdated;
        event EventHandler<ClientDTO> ClientDeleted;
        event EventHandler LoadClientsRequested;
        event EventHandler<long> ClientSearchRequested;
        event EventHandler<ClientDTO> ClientSelected;

        void ShowErrorMessage(string message);
        void UpdateClientsList(IEnumerable<ClientDTO> clients);
        void HighlightClient(ClientDTO client);
        void ShowClientPhoto(string photoPath);
    }

}
