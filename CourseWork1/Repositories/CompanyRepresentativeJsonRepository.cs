using CourseWork1.Interfaces;
using Newtonsoft.Json;
using System;
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
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var companyRepresentativeFile in companyRepresentativeFiles)
            {
                json = File.ReadAllText(companyRepresentativeFile);
                companyRepresentatives.Add(JsonConvert.DeserializeObject<ICompanyRepresentative>(json, options));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var companyRepresentative in companyRepresentatives)
            {
                fileName = $"{companyRepresentative.Id}.json";
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

        public ICompanyRepresentative GetById(long id)
        {
            var compRepr = companyRepresentatives.FirstOrDefault(c => c.Id == id);
            if (compRepr == null) 
            {
                throw new Exception($"Представитель компании с id {id} не найден.");
            }
            return new CompanyRepresentative(id, compRepr.FirstName, compRepr.LastName, compRepr.Patronymic, compRepr.Number, compRepr.Email);
        }

        public void Remove(ICompanyRepresentative companyRepresentative)
        {
            if(companyRepresentatives.Remove(companyRepresentative))
                SaveData();
        }

        public void Update(ICompanyRepresentative companyRepresentative)
        {
            ICompanyRepresentative existingCompanyRepresentative = GetById(companyRepresentative.Id);
            if (existingCompanyRepresentative != null)
            {
                companyRepresentatives[companyRepresentatives.IndexOf(existingCompanyRepresentative)] = companyRepresentative;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить представителя компании, так как он не найден.");
            }
        }
    }
}
