using System;
using System.IO;

namespace CourseWork1
{
    public class Client : Person
    {
        private DateTime dateOfBirth;
        private Passport passportData;
        private string pathToPhoto;
        public static readonly string pathToClients = "..\\..\\..\\clients";


        public Client(string firstName, string lastName, string patronymic, DateTime dateOfBirth, Passport passportData, string pathToPhoto) :
            base(firstName, lastName, patronymic)
        {
            DateOfBirth = dateOfBirth;
            PassportData = passportData;
            PathToPhoto = pathToPhoto;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic} {DateOfBirth} {PassportData.Series} {PassportData.Number}";
        }

        public DateTime DateOfBirth
        {
            set
            {
                if (DateTime.Compare(value, new DateTime(1900,1,1)) > 0)
                {
                    dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Неверная дата рождения");
                }
            }
            get
            {
                return dateOfBirth;
            }
        }

        public Passport PassportData
        {
            set
            {
                if (value != null)
                {
                    passportData = value;
                }
                else
                {
                    throw new Exception("Неверные данные паспорта");
                }
            }
            get
            {
                return passportData;
            }
        }

        public string PathToPhoto
        {
            set
            {
                if (File.Exists(value))
                {
                    pathToPhoto = value;
                }
                else
                {
                    throw new Exception("Такого файла не существует");
                }
            }
            get
            {
                return pathToPhoto;
            }
        }
    }
}
