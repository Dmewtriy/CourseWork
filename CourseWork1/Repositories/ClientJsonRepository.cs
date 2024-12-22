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
            foreach (var clientFile in clientFiles)
            {
                json = File.ReadAllText(clientFile);
                clients.Add(JsonConvert.DeserializeObject<IClient>(json));
            }
        }

        private void SaveData() 
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var client in clients) 
            {
                fileName = $"{client}.json";
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

        public IClient GetById(int id)
        {
            return clients.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            IClient client = GetById(id);
            if (client != null) clients.Remove(client);
        }

        public void Update(IClient client)
        {
            IClient existingClient = GetById(client.Id);
            if (existingClient != null) 
            {
                clients.Remove(existingClient);
                clients.Add(client);
                SaveData();
            }
        }
    }
}
