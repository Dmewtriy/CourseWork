using CourseWork1.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Repositories
{
    public class ClientJsonRepository : IRepository<IClient>
    {
        private readonly string path;
        private List<IClient> clients;

        public ClientJsonRepository(string path)
        {
            this.path = path;
            clients = new List<IClient>();
            LoadData();
        }

        private void LoadData() 
        {
            string[] clientFiles = Directory.GetFiles(path);
            string json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var clientFile in clientFiles)
            {
                json = File.ReadAllText(clientFile);
                clients.Add(JsonConvert.DeserializeObject<IClient>(json, options));
            }
        }

        private void SaveData() 
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var client in clients) 
            {
                fileName = $"{client.Id}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(client, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(IClient client)
        {
            clients.Add(client);
            SaveData();
        }

        public IEnumerable<IClient> GetAll()
        {
            return clients;
        }

        public IClient GetById(long id)
        {
            var client =  clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                throw new Exception($"Клиент с id {id} не найден");
            var clientPassport = client.PassportData;
            return new Client(id, client.FirstName, client.LastName, client.Patronymic, client.DateOfBirth,
                new RUPassport(clientPassport.Series, clientPassport.Number, clientPassport.IssuedDate,
                clientPassport.IssuedBy),
                client.PathToPhoto);
        }

        public void Remove(IClient client)
        {
            if (clients.Remove(client))
                SaveData();
        }

        public void Update(IClient client)
        {
            IClient existingClient = GetById(client.Id);
            if (existingClient != null) 
            {
                clients[clients.IndexOf(existingClient)] = client;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить клиента, так как он не найден.");
            }
        }
    }
}
