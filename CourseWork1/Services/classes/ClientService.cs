using CourseWork1.Interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class ClientService : IClientService
    {
        private readonly IRepository<IClient> repository;

        public ClientService(IRepository<IClient> repository)
        {
            this.repository = repository;
        }

        public bool DeleteClient(IClient client)
        {
            return repository.Remove(client);
        }

        public void EditClient(IClient client)
        {
            repository.Update(client);
        }

        public IEnumerable<IClient> GetAllClients()
        {
            return repository.GetAll();
        }

        public IClient GetClientById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterClient(IClient client)
        {
            long id;
            IClient existingClient = client;
            while (existingClient != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingClient = repository.GetById(id); // бросает исключение, когда клиент не найден
                }
                catch
                {
                    client.Id = id;
                    repository.Add(client);
                    return;
                }

            }
        }
    }
}
