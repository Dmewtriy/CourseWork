using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services;
using CourseWork1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Presenters.classes
{
    public class ClientPresenter : IClientPresenter
    {
        private readonly IClientService service;
        private readonly IClientView view;

        public ClientPresenter(IClientService service, IClientView view)
        {
            this.service = service;
            this.view = view;
            view.ClientAdded += (sender, client) => AddClient(client);
            view.ClientUpdated += (sender, client) => UpdateClient(client);
            view.ClientDeleted += (sender, client) => DeleteClient(client);
            view.LoadClientsRequested += (sender, e) => LoadClients();
            view.ClientSearchRequested += (sender, id) => GetClientById(id);
        }

        public void AddClient(ClientDTO client)
        {
            service.RegisterClient(ClientMapper.ToEntity(client));
            view.UpdateClientsList(GetClients());
        }

        public void DeleteClient(ClientDTO client)
        {
            bool result = service.DeleteClient(ClientMapper.ToEntity(client));
            if (result)
            {
                view.UpdateClientsList(GetClients());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении клиента. Попробуйте еще раз");
            }
        }

        public void GetClientById(long id)
        {
            try
            {
                ClientDTO client = ClientMapper.ToDTO(service.GetClientById(id));
                view.UpdateClientsList(GetClients());
                view.HighlightClient(client);
            }
            catch(Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<ClientDTO> GetClients()
        {
            var clients = service.GetAllClients();
            var clientsDTO = new List<ClientDTO>();
            foreach (var client in clients) 
            {
                clientsDTO.Add(ClientMapper.ToDTO(client));
            }
            return clientsDTO;
        }

        private void LoadClients()
        {
            view.UpdateClientsList(GetClients());
        }

        public void UpdateClient(ClientDTO client)
        {
            try
            {
                service.EditClient(ClientMapper.ToEntity(client));
                view.UpdateClientsList(GetClients());
                view.HighlightClient(client);
            }
            catch (Exception ex) 
            {
                view.ShowErrorMessage(ex.Message);
            }
        }
    }
}
