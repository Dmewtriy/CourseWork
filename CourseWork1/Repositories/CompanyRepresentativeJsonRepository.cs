using CourseWork1.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork1.Repositories
{
    public class CompanyRepresentativeJsonRepository : IRepository<ICompanyRepresentative>
    {
        private readonly string path;
        private List<ICompanyRepresentative> companyRepresentatives;

        public CompanyRepresentativeJsonRepository(string path)
        {
            this.path = path;
            companyRepresentatives = new List<ICompanyRepresentative>();
            LoadData();
        }

        private void LoadData()
        {
            string[] companyRepresentativeFiles = Directory.GetFiles(path);
            string json;
            foreach (var companyRepresentativeFile in companyRepresentativeFiles)
            {
                json = File.ReadAllText(companyRepresentativeFile);
                companyRepresentatives.Add(JsonConvert.DeserializeObject<ICompanyRepresentative>(json));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var companyRepresentative in companyRepresentatives)
            {
                fileName = $"{companyRepresentative}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(companyRepresentative, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(ICompanyRepresentative companyRepresentative)
        {
            companyRepresentatives.Add(companyRepresentative);
            SaveData();
        }

        public IEnumerable<ICompanyRepresentative> GetAll()
        {
            return companyRepresentatives;
        }

        public ICompanyRepresentative GetById(int id)
        {
            return companyRepresentatives.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            ICompanyRepresentative companyRepresentative = GetById(id);
            if (companyRepresentative != null) companyRepresentatives.Remove(companyRepresentative);
            SaveData();
        }

        public void Update(ICompanyRepresentative companyRepresentative)
        {
            ICompanyRepresentative existingCompanyRepresentative = GetById(companyRepresentative.Id);
            if (existingCompanyRepresentative != null)
            {
                companyRepresentatives.Remove(existingCompanyRepresentative);
                companyRepresentatives.Add(companyRepresentative);
                SaveData();
            }
        }
    }
}
